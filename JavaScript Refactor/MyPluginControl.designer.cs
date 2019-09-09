namespace JavaScript_Refactor
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("OnCreate");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("OnSave");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("OnModified \"name\"");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Main Form", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Quick Create");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Account", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Main Form");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Quick Create");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Opportunity", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("FormScripts.js");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Playboox", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSample = new System.Windows.Forms.ToolStripButton();
            this.EntityFormsTreeview = new System.Windows.Forms.TreeView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.tsbSample});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(559, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(86, 22);
            this.tsbClose.Text = "Close this tool";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSample
            // 
            this.tsbSample.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSample.Name = "tsbSample";
            this.tsbSample.Size = new System.Drawing.Size(48, 22);
            this.tsbSample.Text = "Try me";
            this.tsbSample.Click += new System.EventHandler(this.tsbSample_Click);
            // 
            // EntityFormsTreeview
            // 
            this.EntityFormsTreeview.AccessibleName = "Forms";
            this.EntityFormsTreeview.AllowDrop = true;
            this.EntityFormsTreeview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntityFormsTreeview.HideSelection = false;
            this.EntityFormsTreeview.Location = new System.Drawing.Point(289, 3);
            this.EntityFormsTreeview.Name = "EntityFormsTreeview";
            treeNode1.ForeColor = System.Drawing.Color.Green;
            treeNode1.Name = "Node7";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.Text = "OnCreate";
            treeNode1.ToolTipText = "Arguments: \"sdjnfksdjnf\"";
            treeNode2.Name = "Node8";
            treeNode2.Text = "OnSave";
            treeNode3.Name = "Node9";
            treeNode3.Text = "OnModified \"name\"";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Main Form";
            treeNode5.Name = "Node2";
            treeNode5.Text = "Quick Create";
            treeNode6.Name = "Account";
            treeNode6.Text = "Account";
            treeNode6.ToolTipText = "Entity Account";
            treeNode7.Name = "Node4";
            treeNode7.Text = "Main Form";
            treeNode8.Name = "Node6";
            treeNode8.Text = "Quick Create";
            treeNode9.Name = "Node3";
            treeNode9.Text = "Opportunity";
            this.EntityFormsTreeview.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode9});
            this.EntityFormsTreeview.Size = new System.Drawing.Size(261, 381);
            this.EntityFormsTreeview.TabIndex = 5;
            this.EntityFormsTreeview.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode10.Name = "Node1";
            treeNode10.Text = "FormScripts.js";
            treeNode11.Name = "Node0";
            treeNode11.Text = "Playboox";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(260, 381);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EntityFormsTreeview, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 387);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(559, 453);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbSample;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.TreeView EntityFormsTreeview;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
