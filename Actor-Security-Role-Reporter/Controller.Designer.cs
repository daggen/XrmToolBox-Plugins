using System;
using System.Windows.Forms;
using Daggen.SecurityRole.Properties;

namespace Daggen.SecurityRole
{
    partial class Controller
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controller));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonClosePlugin = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRetriveData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonGenerateReport = new System.Windows.Forms.ToolStripButton();
            this.listViewActors = new System.Windows.Forms.ListView();
            this.Actorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BusinessUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnActorType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDisabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonCombine = new System.Windows.Forms.Button();
            this.buttonIntersect = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.radioButtonToSecurityRole = new System.Windows.Forms.RadioButton();
            this.radioButtonToUser = new System.Windows.Forms.RadioButton();
            this.checkBoxIncludeDisabled = new System.Windows.Forms.CheckBox();
            this.checkBoxIncludeTeams = new System.Windows.Forms.CheckBox();
            this.checkBoxIncludeUsers = new System.Windows.Forms.CheckBox();
            this.textBoxNumberOfActors = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfSecurityRoles = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listViewSecurityRoles = new System.Windows.Forms.ListView();
            this.SecurityRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonAddRole = new System.Windows.Forms.Button();
            this.buttonRemoveRole = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabelCheckAllActors = new System.Windows.Forms.LinkLabel();
            this.linkLabelUncheckAllActors = new System.Windows.Forms.LinkLabel();
            this.linkLabelShowAllActors = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabelCheckAllSecurityRoles = new System.Windows.Forms.LinkLabel();
            this.linkLabelUncheckAllSecurityRoles = new System.Windows.Forms.LinkLabel();
            this.linkLabelShowAllRoles = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonClosePlugin,
            this.toolStripButtonRetriveData,
            this.toolStripSeparator1,
            this.toolStripButtonGenerateReport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(733, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonClosePlugin
            // 
            this.toolStripButtonClosePlugin.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClosePlugin.Image")));
            this.toolStripButtonClosePlugin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClosePlugin.Name = "toolStripButtonClosePlugin";
            this.toolStripButtonClosePlugin.Size = new System.Drawing.Size(56, 22);
            this.toolStripButtonClosePlugin.Text = "Close";
            this.toolStripButtonClosePlugin.Click += new System.EventHandler(this.toolStripButtonClosePlugin_Click);
            // 
            // toolStripButtonRetriveData
            // 
            this.toolStripButtonRetriveData.Image = global::Daggen.SecurityRole.Properties.Resources.refresh_button;
            this.toolStripButtonRetriveData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRetriveData.Name = "toolStripButtonRetriveData";
            this.toolStripButtonRetriveData.Size = new System.Drawing.Size(80, 22);
            this.toolStripButtonRetriveData.Text = "Load Data";
            this.toolStripButtonRetriveData.Click += new System.EventHandler(this.toolStripButtonRetriveData_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonGenerateReport
            // 
            this.toolStripButtonGenerateReport.Enabled = false;
            this.toolStripButtonGenerateReport.Image = global::Daggen.SecurityRole.Properties.Resources.analytic_report;
            this.toolStripButtonGenerateReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGenerateReport.Name = "toolStripButtonGenerateReport";
            this.toolStripButtonGenerateReport.Size = new System.Drawing.Size(112, 22);
            this.toolStripButtonGenerateReport.Text = "Generate Report";
            this.toolStripButtonGenerateReport.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // listViewActors
            // 
            this.listViewActors.CheckBoxes = true;
            this.listViewActors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Actorname,
            this.BusinessUnit,
            this.ColumnActorType,
            this.ColumnDisabled});
            this.listViewActors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewActors.Location = new System.Drawing.Point(3, 23);
            this.listViewActors.Name = "listViewActors";
            this.listViewActors.Size = new System.Drawing.Size(300, 390);
            this.listViewActors.TabIndex = 9;
            this.listViewActors.UseCompatibleStateImageBehavior = false;
            this.listViewActors.View = System.Windows.Forms.View.Details;
            this.listViewActors.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewUsers_ColumnClick);
            this.listViewActors.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewUsers_ItemChecked);
            this.listViewActors.DoubleClick += new System.EventHandler(this.listViewUsers_DoubleClick);
            this.listViewActors.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewUsers_SelectedIndexChanged);
            // 
            // Actorname
            // 
            this.Actorname.Text = "Name";
            this.Actorname.Width = 150;
            // 
            // BusinessUnit
            // 
            this.BusinessUnit.Text = "Business Unit";
            this.BusinessUnit.Width = 140;
            // 
            // ColumnActorType
            // 
            this.ColumnActorType.Text = "Type";
            this.ColumnActorType.Width = 50;
            // 
            // ColumnDisabled
            // 
            this.ColumnDisabled.Text = "Disabled";
            this.ColumnDisabled.Width = 50;
            // 
            // buttonCombine
            // 
            this.buttonCombine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.buttonCombine, 2);
            this.buttonCombine.Location = new System.Drawing.Point(9, 53);
            this.buttonCombine.Name = "buttonCombine";
            this.buttonCombine.Size = new System.Drawing.Size(96, 19);
            this.buttonCombine.TabIndex = 1;
            this.buttonCombine.Text = "Combine";
            this.buttonCombine.UseVisualStyleBackColor = true;
            this.buttonCombine.Click += new System.EventHandler(this.buttonCombine_Click);
            // 
            // buttonIntersect
            // 
            this.buttonIntersect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.buttonIntersect, 2);
            this.buttonIntersect.Location = new System.Drawing.Point(9, 78);
            this.buttonIntersect.Name = "buttonIntersect";
            this.buttonIntersect.Size = new System.Drawing.Size(96, 19);
            this.buttonIntersect.TabIndex = 1;
            this.buttonIntersect.Text = "Intersect";
            this.buttonIntersect.UseVisualStyleBackColor = true;
            this.buttonIntersect.Click += new System.EventHandler(this.buttonIntersect_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.SetColumnSpan(this.buttonReset, 2);
            this.buttonReset.Location = new System.Drawing.Point(9, 103);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(96, 19);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // radioButtonToSecurityRole
            // 
            this.radioButtonToSecurityRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonToSecurityRole.AutoSize = true;
            this.radioButtonToSecurityRole.Checked = true;
            this.radioButtonToSecurityRole.Location = new System.Drawing.Point(67, 29);
            this.radioButtonToSecurityRole.Name = "radioButtonToSecurityRole";
            this.radioButtonToSecurityRole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButtonToSecurityRole.Size = new System.Drawing.Size(37, 17);
            this.radioButtonToSecurityRole.TabIndex = 10;
            this.radioButtonToSecurityRole.TabStop = true;
            this.radioButtonToSecurityRole.Text = "<--";
            this.radioButtonToSecurityRole.UseVisualStyleBackColor = true;
            // 
            // radioButtonToUser
            // 
            this.radioButtonToUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonToUser.AutoSize = true;
            this.radioButtonToUser.Location = new System.Drawing.Point(10, 29);
            this.radioButtonToUser.Name = "radioButtonToUser";
            this.radioButtonToUser.Size = new System.Drawing.Size(37, 17);
            this.radioButtonToUser.TabIndex = 10;
            this.radioButtonToUser.Text = "<--";
            this.radioButtonToUser.UseVisualStyleBackColor = true;
            // 
            // checkBoxIncludeDisabled
            // 
            this.checkBoxIncludeDisabled.AutoSize = true;
            this.checkBoxIncludeDisabled.Location = new System.Drawing.Point(3, 26);
            this.checkBoxIncludeDisabled.Name = "checkBoxIncludeDisabled";
            this.checkBoxIncludeDisabled.Size = new System.Drawing.Size(103, 17);
            this.checkBoxIncludeDisabled.TabIndex = 11;
            this.checkBoxIncludeDisabled.Text = "Include disabled";
            this.checkBoxIncludeDisabled.UseVisualStyleBackColor = true;
            this.checkBoxIncludeDisabled.CheckedChanged += new System.EventHandler(this.checkBoxIncludeFilters_CheckedChanged);
            // 
            // checkBoxIncludeTeams
            // 
            this.checkBoxIncludeTeams.AutoSize = true;
            this.checkBoxIncludeTeams.Checked = true;
            this.checkBoxIncludeTeams.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIncludeTeams.Location = new System.Drawing.Point(100, 3);
            this.checkBoxIncludeTeams.Name = "checkBoxIncludeTeams";
            this.checkBoxIncludeTeams.Size = new System.Drawing.Size(96, 17);
            this.checkBoxIncludeTeams.TabIndex = 12;
            this.checkBoxIncludeTeams.Text = "Include Teams";
            this.checkBoxIncludeTeams.UseVisualStyleBackColor = true;
            this.checkBoxIncludeTeams.CheckedChanged += new System.EventHandler(this.checkBoxIncludeFilters_CheckedChanged);
            // 
            // checkBoxIncludeUsers
            // 
            this.checkBoxIncludeUsers.AutoSize = true;
            this.checkBoxIncludeUsers.Checked = true;
            this.checkBoxIncludeUsers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIncludeUsers.Location = new System.Drawing.Point(3, 3);
            this.checkBoxIncludeUsers.Name = "checkBoxIncludeUsers";
            this.checkBoxIncludeUsers.Size = new System.Drawing.Size(91, 17);
            this.checkBoxIncludeUsers.TabIndex = 12;
            this.checkBoxIncludeUsers.Text = "Include Users";
            this.checkBoxIncludeUsers.UseVisualStyleBackColor = true;
            this.checkBoxIncludeUsers.CheckedChanged += new System.EventHandler(this.checkBoxIncludeFilters_CheckedChanged);
            // 
            // textBoxNumberOfActors
            // 
            this.textBoxNumberOfActors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNumberOfActors.BackColor = System.Drawing.Color.White;
            this.textBoxNumberOfActors.Location = new System.Drawing.Point(10, 128);
            this.textBoxNumberOfActors.Name = "textBoxNumberOfActors";
            this.textBoxNumberOfActors.ReadOnly = true;
            this.textBoxNumberOfActors.Size = new System.Drawing.Size(37, 20);
            this.textBoxNumberOfActors.TabIndex = 13;
            this.textBoxNumberOfActors.Text = "0";
            this.textBoxNumberOfActors.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxNumberOfSecurityRoles
            // 
            this.textBoxNumberOfSecurityRoles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNumberOfSecurityRoles.BackColor = System.Drawing.Color.White;
            this.textBoxNumberOfSecurityRoles.Location = new System.Drawing.Point(67, 128);
            this.textBoxNumberOfSecurityRoles.Name = "textBoxNumberOfSecurityRoles";
            this.textBoxNumberOfSecurityRoles.ReadOnly = true;
            this.textBoxNumberOfSecurityRoles.Size = new System.Drawing.Size(37, 20);
            this.textBoxNumberOfSecurityRoles.TabIndex = 13;
            this.textBoxNumberOfSecurityRoles.Text = "0";
            this.textBoxNumberOfSecurityRoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listViewActors, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listViewSecurityRoles, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(733, 466);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // listViewSecurityRoles
            // 
            this.listViewSecurityRoles.CheckBoxes = true;
            this.listViewSecurityRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SecurityRole});
            this.listViewSecurityRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSecurityRoles.Location = new System.Drawing.Point(429, 23);
            this.listViewSecurityRoles.Name = "listViewSecurityRoles";
            this.listViewSecurityRoles.Size = new System.Drawing.Size(301, 390);
            this.listViewSecurityRoles.TabIndex = 9;
            this.listViewSecurityRoles.UseCompatibleStateImageBehavior = false;
            this.listViewSecurityRoles.View = System.Windows.Forms.View.Details;
            this.listViewSecurityRoles.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewSecurityRoles_ColumnClick);
            this.listViewSecurityRoles.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewSecurityRoles_ItemChecked);
            this.listViewSecurityRoles.DoubleClick += new System.EventHandler(this.listViewSecurityRoles_DoubleClick);
            this.listViewSecurityRoles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewSecurityRoles_SelectedIndexChanged);
            // 
            // SecurityRole
            // 
            this.SecurityRole.Text = "Security Role";
            this.SecurityRole.Width = 268;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.checkBoxIncludeUsers);
            this.flowLayoutPanel2.Controls.Add(this.checkBoxIncludeTeams);
            this.flowLayoutPanel2.Controls.Add(this.checkBoxIncludeDisabled);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 419);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(300, 44);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(309, 419);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(114, 44);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.radioButtonToSecurityRole, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonToUser, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonReset, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonIntersect, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonCombine, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxNumberOfActors, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBoxNumberOfSecurityRoles, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.buttonAddRole, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.buttonRemoveRole, 0, 9);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(309, 90);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(114, 255);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel2.SetColumnSpan(this.textBox1, 2);
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 13);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Filter";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel2.SetColumnSpan(this.textBox2, 2);
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(3, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 13);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "Actions";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAddRole
            // 
            this.buttonAddRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.buttonAddRole, 2);
            this.buttonAddRole.Location = new System.Drawing.Point(3, 203);
            this.buttonAddRole.Name = "buttonAddRole";
            this.buttonAddRole.Size = new System.Drawing.Size(108, 19);
            this.buttonAddRole.TabIndex = 16;
            this.buttonAddRole.Text = "Add Roles";
            this.buttonAddRole.UseVisualStyleBackColor = true;
            this.buttonAddRole.Click += new System.EventHandler(this.buttonAddRole_Click);
            // 
            // buttonRemoveRole
            // 
            this.buttonRemoveRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.buttonRemoveRole, 2);
            this.buttonRemoveRole.Location = new System.Drawing.Point(3, 228);
            this.buttonRemoveRole.Name = "buttonRemoveRole";
            this.buttonRemoveRole.Size = new System.Drawing.Size(108, 24);
            this.buttonRemoveRole.TabIndex = 17;
            this.buttonRemoveRole.Text = "Remove Roles";
            this.buttonRemoveRole.UseVisualStyleBackColor = true;
            this.buttonRemoveRole.Click += new System.EventHandler(this.buttonRemoveRole_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.linkLabelCheckAllActors);
            this.flowLayoutPanel3.Controls.Add(this.linkLabelUncheckAllActors);
            this.flowLayoutPanel3.Controls.Add(this.linkLabelShowAllActors);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(200, 14);
            this.flowLayoutPanel3.TabIndex = 13;
            // 
            // linkLabelCheckAllActors
            // 
            this.linkLabelCheckAllActors.AutoSize = true;
            this.linkLabelCheckAllActors.Location = new System.Drawing.Point(3, 0);
            this.linkLabelCheckAllActors.Name = "linkLabelCheckAllActors";
            this.linkLabelCheckAllActors.Size = new System.Drawing.Size(52, 13);
            this.linkLabelCheckAllActors.TabIndex = 0;
            this.linkLabelCheckAllActors.TabStop = true;
            this.linkLabelCheckAllActors.Text = "Check All";
            this.linkLabelCheckAllActors.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // linkLabelUncheckAllActors
            // 
            this.linkLabelUncheckAllActors.AutoSize = true;
            this.linkLabelUncheckAllActors.Location = new System.Drawing.Point(61, 0);
            this.linkLabelUncheckAllActors.Name = "linkLabelUncheckAllActors";
            this.linkLabelUncheckAllActors.Size = new System.Drawing.Size(64, 13);
            this.linkLabelUncheckAllActors.TabIndex = 1;
            this.linkLabelUncheckAllActors.TabStop = true;
            this.linkLabelUncheckAllActors.Text = "Uncheck all";
            this.linkLabelUncheckAllActors.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUncheckAllActors_LinkClicked);
            // 
            // linkLabelShowAllActors
            // 
            this.linkLabelShowAllActors.AutoSize = true;
            this.linkLabelShowAllActors.Location = new System.Drawing.Point(131, 0);
            this.linkLabelShowAllActors.Name = "linkLabelShowAllActors";
            this.linkLabelShowAllActors.Size = new System.Drawing.Size(47, 13);
            this.linkLabelShowAllActors.TabIndex = 1;
            this.linkLabelShowAllActors.TabStop = true;
            this.linkLabelShowAllActors.Text = "Show all";
            this.linkLabelShowAllActors.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelShowAllActors_LinkClicked);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.linkLabelCheckAllSecurityRoles);
            this.flowLayoutPanel4.Controls.Add(this.linkLabelUncheckAllSecurityRoles);
            this.flowLayoutPanel4.Controls.Add(this.linkLabelShowAllRoles);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(429, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(200, 14);
            this.flowLayoutPanel4.TabIndex = 14;
            // 
            // linkLabelCheckAllSecurityRoles
            // 
            this.linkLabelCheckAllSecurityRoles.AutoSize = true;
            this.linkLabelCheckAllSecurityRoles.Location = new System.Drawing.Point(3, 0);
            this.linkLabelCheckAllSecurityRoles.Name = "linkLabelCheckAllSecurityRoles";
            this.linkLabelCheckAllSecurityRoles.Size = new System.Drawing.Size(51, 13);
            this.linkLabelCheckAllSecurityRoles.TabIndex = 0;
            this.linkLabelCheckAllSecurityRoles.TabStop = true;
            this.linkLabelCheckAllSecurityRoles.Text = "Check all";
            this.linkLabelCheckAllSecurityRoles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCheckAllSecurityRoles_LinkClicked);
            // 
            // linkLabelUncheckAllSecurityRoles
            // 
            this.linkLabelUncheckAllSecurityRoles.AutoSize = true;
            this.linkLabelUncheckAllSecurityRoles.Location = new System.Drawing.Point(60, 0);
            this.linkLabelUncheckAllSecurityRoles.Name = "linkLabelUncheckAllSecurityRoles";
            this.linkLabelUncheckAllSecurityRoles.Size = new System.Drawing.Size(64, 13);
            this.linkLabelUncheckAllSecurityRoles.TabIndex = 1;
            this.linkLabelUncheckAllSecurityRoles.TabStop = true;
            this.linkLabelUncheckAllSecurityRoles.Text = "Uncheck all";
            this.linkLabelUncheckAllSecurityRoles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUncheckAllSecurityRoles_LinkClicked);
            // 
            // linkLabelShowAllRoles
            // 
            this.linkLabelShowAllRoles.AutoSize = true;
            this.linkLabelShowAllRoles.Location = new System.Drawing.Point(130, 0);
            this.linkLabelShowAllRoles.Name = "linkLabelShowAllRoles";
            this.linkLabelShowAllRoles.Size = new System.Drawing.Size(47, 13);
            this.linkLabelShowAllRoles.TabIndex = 1;
            this.linkLabelShowAllRoles.TabStop = true;
            this.linkLabelShowAllRoles.Text = "Show all";
            this.linkLabelShowAllRoles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelShowAllRoles_LinkClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Controller";
            this.Size = new System.Drawing.Size(733, 491);
            this.Load += new System.EventHandler(this.Controller_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonClosePlugin;
        private System.Windows.Forms.ToolStripButton toolStripButtonRetriveData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonGenerateReport;
        private System.Windows.Forms.ListView listViewActors;
        private System.Windows.Forms.ColumnHeader Actorname;
        private System.Windows.Forms.ColumnHeader BusinessUnit;
        private System.Windows.Forms.ColumnHeader ColumnActorType;
        private System.Windows.Forms.ColumnHeader ColumnDisabled;
        private System.Windows.Forms.Button buttonIntersect;
        private System.Windows.Forms.Button buttonCombine;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.RadioButton radioButtonToSecurityRole;
        private System.Windows.Forms.RadioButton radioButtonToUser;
        private System.Windows.Forms.CheckBox checkBoxIncludeDisabled;
        private System.Windows.Forms.CheckBox checkBoxIncludeTeams;
        private System.Windows.Forms.CheckBox checkBoxIncludeUsers;
        private TextBox textBoxNumberOfActors;
        private TextBox textBoxNumberOfSecurityRoles;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private ColumnHeader SecurityRole;
        private ListView listViewSecurityRoles;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private LinkLabel linkLabelUncheckAllActors;
        private FlowLayoutPanel flowLayoutPanel4;
        private LinkLabel linkLabelCheckAllSecurityRoles;
        private LinkLabel linkLabelUncheckAllSecurityRoles;
        private LinkLabel linkLabelCheckAllActors;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonAddRole;
        private Button buttonRemoveRole;
        private ContextMenuStrip contextMenuStrip1;
        private LinkLabel linkLabelShowAllActors;
        private LinkLabel linkLabelShowAllRoles;
    }
}
