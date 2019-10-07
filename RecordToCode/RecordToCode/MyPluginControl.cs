using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;

namespace Daggen.RecordToCode
{
    public partial class MyPluginControl : PluginControlBase
    {
        private Settings mySettings;

        public MyPluginControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tsbSample_Click(object sender, EventArgs e)
        {
            var record =
                Service.Retrieve(textBoxEntityType.Text,
                    new Guid(textBoxGuid.Text),
                    new ColumnSet(true));

            textBoxCode.Text = $"var rec = new Entity(\"{record.LogicalName}\") {{" +
                string.Join("," + Environment.NewLine, record.Attributes
                .Select(ToString)
                .OrderBy(t => t)) + "};";
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private string ToString(KeyValuePair<string, object> attr)
        {
            var key = attr.Key;
            var value = attr.Value;

            return $"[\"{key}\"] = {ToStringValue(value)}";
        }

        private string ToStringValue(object value)
        {
            var ngi = new NumberFormatInfo {NumberDecimalSeparator = "."};
            switch (value)
            {
                case EntityReference e:
                    return $"new EntityReference(\"{e.LogicalName}\", new Guid(\"{e.Id}\"))";
                case OptionSetValue o:
                    return $"new OptionSetValue({o.Value})";
                case DateTime d:
                    return $"new DateTime({d.Year}, {d.Month}, {d.Day}, {d.Hour}, {d.Minute}, {d.Second})";
                case Money m:
                    return $"new Money({m.Value.ToString(ngi)}M)";
                case Guid d:
                    return $"new Guid(\"{d.ToString()}\")";
                case bool b:
                    return b ? "true" : "false";
                case decimal d:
                    return d.ToString(ngi)+"M";
                case double d:
                    return d.ToString(ngi);
                case float f:
                    return f.ToString(ngi);
                case int i:
                    return i.ToString();

                default:
                    return $"\"{value.ToString()}\"";
            }
        }
    }
}