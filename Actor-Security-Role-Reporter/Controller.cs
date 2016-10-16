using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Daggen.SecurityRole.Model;
using Daggen.SecurityRole.Properties;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace Daggen.SecurityRole
{
    public partial class Controller : PluginControlBase, IPayPalPlugin, IGitHubPlugin
    {
        private List<Actor> actors = new List<Actor>();
        private IEnumerable<Actor> workingListActors = new List<Actor>();
        private List<Model.SecurityRole> roles = new List<Model.SecurityRole>();
        private string reportPath = "";
        private int userListViewColumnOrder = -1;

        private const string DataFile = "ActorRoleData{0}.csv";
        private const string ReportFile = "ActorSecurityRoleReport.xlsx";

        public Controller()
        {
            InitializeComponent();
        }

        private void Controller_Load(object sender, EventArgs e)
        {

        }

        private IEnumerable<ActorInRole> GetActorsInSecurityRoles()
        {
            var qEsystemuserroles = new QueryExpression("systemuserroles");
            qEsystemuserroles.ColumnSet.AddColumns("roleid", "systemuserid");
            var list = Service.RetrieveMultiple(qEsystemuserroles).Entities
                .Select(e => new ActorInRole {
                    Actor = (Guid) e.Attributes["systemuserid"],
                    Role = (Guid) e.Attributes["roleid"]}).ToList();
            
            var qEteamroles = new QueryExpression("teamroles");
            qEteamroles.ColumnSet.AddColumns("roleid", "teamid");
            list.AddRange(Service.RetrieveMultiple(qEteamroles).Entities
                .Select(e => new ActorInRole
                {
                    Actor = (Guid) e.Attributes["teamid"],
                    Role = (Guid) e.Attributes["roleid"]
                }));

            return list;
        }

        private List<Model.SecurityRole> GetRoles()
        {
            var qErole = new QueryExpression("role");
            qErole.ColumnSet.AddColumns("name", "parentroleid");

            return Service.RetrieveMultiple(qErole).Entities
                .GroupBy(e => e.Attributes["name"].ToString(),
                    e => new {e.Id, IsParent = !e.Contains("parentroleid") },
                    (name, ids) => new Model.SecurityRole
                    {
                        Role = name,
                        Id = ids.First(l => l.IsParent).Id,
                        Ids = ids.Select(l => l.Id).ToList()
                    }).ToList();
        }

        private List<Actor> GetActors()
        {
            var qEsystemuser = new QueryExpression("systemuser");
            qEsystemuser.ColumnSet.AddColumns("systemuserid", "businessunitid", "fullname", "isdisabled");
            var qEteam = new QueryExpression("team");
            qEteam.ColumnSet.AddColumns("name", "businessunitid");
            qEteam.Criteria.AddCondition("teamtype", ConditionOperator.Equal, 0);

            var list = Service.RetrieveMultiple(qEsystemuser).Entities.Select(e => new Actor()
            {
                Name = (string)e.Attributes["fullname"],
                IsDisabled = (bool)e.Attributes["isdisabled"],
                BusinessUnit = ((EntityReference)e.Attributes["businessunitid"]).Name,
                Id = e.Id,
                Type = ActorType.User
            }).ToList();

            list.AddRange(Service.RetrieveMultiple(qEteam).Entities.Select(e => new Actor
            {
                Name = e.Attributes["name"].ToString(),
                IsDisabled = false,
                BusinessUnit = ((EntityReference)e.Attributes["businessunitid"]).Name,
                Id = e.Id,
                Type = ActorType.Team
            }));

            return list;
        }

        private void toolStripButtonClosePlugin_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void toolStripButtonRetriveData_Click(object sender, EventArgs ea)
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading",
                Work = (w, e) =>
                    {
                        w.ReportProgress(0, "Loading Actors");
                        actors = GetActors();

                        w.ReportProgress(25, "Loading Security Roles");
                        roles = GetRoles();

                        w.ReportProgress(50, "Loading Actor Security Role Mapping");
                        foreach (var actorInSecurityRole in GetActorsInSecurityRoles())
                        {
                            var actor = actors.First(a => a.Id.Equals(actorInSecurityRole.Actor));
                            var role = roles.First(r => r.Ids.Contains(actorInSecurityRole.Role));
                            actor.SecurityRoles.Add(role);
                            role.Actors.Add(actor);
                        }

                        w.ReportProgress(75, "Finishing");
                    },
                PostWorkCallBack = e =>
                    {
                        PopulateListViews();
                        toolStripButtonGenerateReport.Enabled = true;
                    },
                ProgressChanged = e =>
                    {
                        SetWorkingMessage(e.UserState.ToString());
                    }
            });
        }

        private void PopulateListViews()
        {
            SetActorList(actors);
            SortListView(listViewActors);

            SetSecurityRoleList(roles);
            SortListView(listViewSecurityRoles);
        }

        private ListViewItem[] GetUsersAsListViewItems(IEnumerable<Actor> users)
        {
            return users.Select(user => new ListViewItem
            {
                Text = user.Name,
                ImageIndex = 0,
                StateImageIndex = 0,
                Tag = user,
                SubItems = {user.BusinessUnit, user.Type.ToString(), user.IsDisabled ? "Yes": ""}
            }).ToArray();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog
            {
                Description = Resources.Controller_button2_Click_Select_where_to_save_the_files_,
                SelectedPath = reportPath
            };
            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;

            reportPath = dialog.SelectedPath;

            using (var file =
                new StreamWriter(reportPath + "/" + string.Format(DataFile, DateTime.Now.ToString("yyyyMMddHHmmss")), false, Encoding.UTF8))
            {
                file.WriteLine(string.Join(";", "Name", "Security Role", "Business Unit", "Status", "Type"));
                foreach (var actor in actors)
                {
                    foreach (var role in actor.SecurityRoles)
                    {
                        file.WriteLine(string.Join(";", actor.Name, role.Role, actor.BusinessUnit, actor.IsDisabled ? "Disabled" : "Active", actor.Type.ToString()));
                    }
                }
            }
            File.WriteAllBytes(reportPath + "/" + ReportFile,
                Resources.ActorSecurityRoleReport);

            MessageBox.Show(Resources.Controller_toolStripButton1_Click_Report_is_now_saved);
        }

        private void ListViewUsers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == userListViewColumnOrder)
            {
                SortListView(listViewActors, e.Column, listViewActors.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending);
            }
            else
            {
                userListViewColumnOrder = e.Column;
                SortListView(listViewActors, e.Column);
            }
        }

        private void listViewSecurityRoles_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(listViewSecurityRoles, e.Column, listViewSecurityRoles.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending);
        }

        private void SortListView(ListView listView, int column = 0, SortOrder order = SortOrder.Ascending)
        {
            listView.Sorting = order;
            listView.ListViewItemSorter = new ListViewItemComparer(column, listView.Sorting);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            PopulateListViews();
        }

        private void buttonCombine_Click(object sender, EventArgs e)
        {
            if (radioButtonToSecurityRole.Checked)
            {
                if (listViewActors.CheckedItems.Count == 0)
                {
                    MessageBox.Show(Resources.WarningOnEmptySelection);
                    return;
                }
                SetSecurityRoleList(listViewActors.CheckedItems.Cast<ListViewItem>()
                    .Select(item => ((Actor)item.Tag).SecurityRoles)
                    .SelectMany(ls => ls));
            }
            else
            {
                if (listViewSecurityRoles.CheckedItems.Count == 0)
                {
                    MessageBox.Show(Resources.WarningOnEmptySelection);
                    return;
                }
                SetActorList(listViewSecurityRoles.CheckedItems.Cast<ListViewItem>()
                        .Select(item => ((Model.SecurityRole)item.Tag).Actors)
                        .SelectMany(ls => ls));
            }
        }

        private static ListViewItem[] GetSecurityRoleAsListViewItems(IEnumerable<Model.SecurityRole> securityRoles)
        {
            return securityRoles
                .Select(securityRole => new ListViewItem
                {
                    Text = securityRole.Role,
                    ImageIndex = 0,
                    StateImageIndex = 0,
                    Tag = securityRole
                }).ToArray();
        }

        private void buttonIntersect_Click(object sender, EventArgs e)
        {
            if (radioButtonToSecurityRole.Checked)
            {
                if (listViewActors.CheckedItems.Count == 0)
                {
                    MessageBox.Show(Resources.WarningOnEmptySelection);
                    return;
                }

                SetSecurityRoleList(listViewActors.CheckedItems.Cast<ListViewItem>()
                    .Select(item => ((Actor)item.Tag).SecurityRoles)
                        .Select(l => (IEnumerable<Model.SecurityRole>) l)
                        .Aggregate((w, n) => n.Intersect(w)));
            }
            else
            {
                if (listViewSecurityRoles.CheckedItems.Count == 0)
                {
                    MessageBox.Show(Resources.WarningOnEmptySelection);
                    return;
                }

                SetActorList(listViewSecurityRoles.CheckedItems.Cast<ListViewItem>()
                    .Select(item => ((Model.SecurityRole)item.Tag).Actors)
                        .Select(l => (IEnumerable<Actor>)l)
                        .Aggregate((w, n) => n.Intersect(w)));
            }
        }

        private void SetActorList(IEnumerable<Actor> actors)
        {
            workingListActors = actors;
            listViewActors.Items.Clear();
            var toSet = FilterActors(workingListActors).Distinct().ToList();
            textBoxNumberOfActors.Text = toSet.Count.ToString();
            listViewActors.Items.AddRange(
                    GetUsersAsListViewItems(toSet));
        }
        private void SetSecurityRoleList(IEnumerable<Model.SecurityRole> securityRoles)
        {
            listViewSecurityRoles.Items.Clear();
            var toSet = securityRoles.Distinct().ToList();
            textBoxNumberOfSecurityRoles.Text = toSet.Count.ToString();
            listViewSecurityRoles.Items.AddRange(
                    GetSecurityRoleAsListViewItems(toSet));
        }

        private IEnumerable<Actor> FilterActors(IEnumerable<Actor> actors)
        {
            if (!checkBoxIncludeTeams.Checked)
                actors = actors.Where(a => a.Type != ActorType.Team);
            
            if (!checkBoxIncludeUsers.Checked)
                actors = actors.Where(a => a.Type != ActorType.User);

            if (!checkBoxIncludeDisabled.Checked)
                actors = actors.Where(a => !a.IsDisabled);
            
            return actors.ToList();
        }

        private void listViewUsers_SelectedIndexChanged(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1
                && listViewActors.SelectedItems.Count > 0 
                && listViewSecurityRoles.CheckedItems.Count == 0)
                SetSecurityRoleList(((Actor) listViewActors.SelectedItems.Cast<ListViewItem>().Last().Tag).SecurityRoles);
        }

        private void listViewUsers_DoubleClick(object sender, EventArgs e)
        {
            var item = (Actor) ((ListView) sender).SelectedItems.Cast<ListViewItem>().Last().Tag;
            var type = item.Type == ActorType.User ? "systemuser" : "team";
            Process.Start(ConnectionDetail.WebApplicationUrl + "/main.aspx?etn=" + type + "&pagetype=entityrecord&id={" + item.Id +"}");
        }

        private void listViewSecurityRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSecurityRoles.SelectedItems.Count == 0
                || listViewActors.CheckedItems.Count > 0)
                return;
            SetActorList(((Model.SecurityRole)listViewSecurityRoles.SelectedItems.Cast<ListViewItem>().Last().Tag).Actors);
        }
        private void listViewSecurityRoles_DoubleClick(object sender, EventArgs e)
        {
            var item = (Model.SecurityRole)((ListView)sender).SelectedItems.Cast<ListViewItem>().Last().Tag;
            Process.Start(ConnectionDetail.WebApplicationUrl + "/biz/roles/edit.aspx?id={" + item.Id + "}");
        }

        private void checkBoxIncludeFilters_CheckedChanged(object sender, EventArgs e)
        {
            SetActorList(workingListActors);
        }

        private void listViewSecurityRoles_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            radioButtonToUser.Checked = true;
        }

        private void listViewUsers_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            radioButtonToSecurityRole.Checked = true;
        }

        public string DonationDescription => "Donation for User Team and Security Role Xrm Plugin";

        public string EmailAccount => "daggen@gmail.com";
        public string RepositoryName => "XrmToolBox-Plugins";
        public string UserName => "daggen";


        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (var item in listViewActors.Items.Cast<ListViewItem>())
            {
                item.Checked = true;
            }
        }

        private void linkLabelUncheckAllActors_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (var item in listViewActors.Items.Cast<ListViewItem>())
            {
                item.Checked = false;
            }
        }

        private void linkLabelCheckAllSecurityRoles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (var item in listViewSecurityRoles.Items.Cast<ListViewItem>())
            {
                item.Checked = true;
            }
        }

        private void linkLabelUncheckAllSecurityRoles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (var item in listViewSecurityRoles.Items.Cast<ListViewItem>())
            {
                item.Checked = false;
            }
        }
    }
}