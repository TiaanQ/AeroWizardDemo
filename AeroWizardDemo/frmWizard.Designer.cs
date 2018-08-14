namespace AeroWizardDemo
{
    partial class frmWizard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wcServerSettings = new AeroWizard.WizardControl();
            this.wpSqlServerSettings = new AeroWizard.WizardPage();
            this.mpSqlServerDisplay = new MetroFramework.Controls.MetroPanel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.clbTables = new System.Windows.Forms.CheckedListBox();
            this.lblTables = new System.Windows.Forms.Label();
            this.cmbSqlDatabases = new System.Windows.Forms.ComboBox();
            this.lblDatabases = new System.Windows.Forms.Label();
            this.cmbSqlServers = new System.Windows.Forms.ComboBox();
            this.lblSqlServer = new System.Windows.Forms.Label();
            this.wpMySqlSettings = new AeroWizard.WizardPage();
            this.cbIncludeSP = new System.Windows.Forms.CheckBox();
            this.cbIncludeFunctions = new System.Windows.Forms.CheckBox();
            this.cbIncludeTriggers = new System.Windows.Forms.CheckBox();
            this.cbIncludeViews = new System.Windows.Forms.CheckBox();
            this.pnlMySqlDisplay = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomName = new System.Windows.Forms.TextBox();
            this.cbCustomName = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMySqlServers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wcServerSettings)).BeginInit();
            this.wpSqlServerSettings.SuspendLayout();
            this.mpSqlServerDisplay.SuspendLayout();
            this.wpMySqlSettings.SuspendLayout();
            this.pnlMySqlDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // wcServerSettings
            // 
            this.wcServerSettings.BackColor = System.Drawing.Color.White;
            this.wcServerSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wcServerSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wcServerSettings.Location = new System.Drawing.Point(0, 0);
            this.wcServerSettings.Name = "wcServerSettings";
            this.wcServerSettings.Pages.Add(this.wpSqlServerSettings);
            this.wcServerSettings.Pages.Add(this.wpMySqlSettings);
            this.wcServerSettings.Size = new System.Drawing.Size(484, 361);
            this.wcServerSettings.TabIndex = 0;
            this.wcServerSettings.Text = "Migration Wizard";
            this.wcServerSettings.Title = "Migration Wizard";
            this.wcServerSettings.SelectedPageChanged += new System.EventHandler(this.wcServerSettings_SelectedPageChanged);
            // 
            // wpSqlServerSettings
            // 
            this.wpSqlServerSettings.AllowBack = false;
            this.wpSqlServerSettings.Controls.Add(this.mpSqlServerDisplay);
            this.wpSqlServerSettings.Name = "wpSqlServerSettings";
            this.wpSqlServerSettings.NextPage = this.wpMySqlSettings;
            this.wpSqlServerSettings.Size = new System.Drawing.Size(437, 207);
            this.wpSqlServerSettings.TabIndex = 0;
            this.wpSqlServerSettings.Text = "SQL Server Settings";
            // 
            // mpSqlServerDisplay
            // 
            this.mpSqlServerDisplay.Controls.Add(this.cbIncludeViews);
            this.mpSqlServerDisplay.Controls.Add(this.cbIncludeTriggers);
            this.mpSqlServerDisplay.Controls.Add(this.cbIncludeFunctions);
            this.mpSqlServerDisplay.Controls.Add(this.cbIncludeSP);
            this.mpSqlServerDisplay.Controls.Add(this.checkBox2);
            this.mpSqlServerDisplay.Controls.Add(this.checkBox1);
            this.mpSqlServerDisplay.Controls.Add(this.clbTables);
            this.mpSqlServerDisplay.Controls.Add(this.lblTables);
            this.mpSqlServerDisplay.Controls.Add(this.cmbSqlDatabases);
            this.mpSqlServerDisplay.Controls.Add(this.lblDatabases);
            this.mpSqlServerDisplay.Controls.Add(this.cmbSqlServers);
            this.mpSqlServerDisplay.Controls.Add(this.lblSqlServer);
            this.mpSqlServerDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mpSqlServerDisplay.HorizontalScrollbarBarColor = true;
            this.mpSqlServerDisplay.HorizontalScrollbarHighlightOnWheel = false;
            this.mpSqlServerDisplay.HorizontalScrollbarSize = 10;
            this.mpSqlServerDisplay.Location = new System.Drawing.Point(0, 0);
            this.mpSqlServerDisplay.Name = "mpSqlServerDisplay";
            this.mpSqlServerDisplay.Size = new System.Drawing.Size(437, 207);
            this.mpSqlServerDisplay.TabIndex = 0;
            this.mpSqlServerDisplay.VerticalScrollbarBarColor = true;
            this.mpSqlServerDisplay.VerticalScrollbarHighlightOnWheel = false;
            this.mpSqlServerDisplay.VerticalScrollbarSize = 10;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(261, 11);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(128, 19);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Include Constraints";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(261, 40);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Include Data";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // clbTables
            // 
            this.clbTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbTables.FormattingEnabled = true;
            this.clbTables.Items.AddRange(new object[] {
            "Blog",
            "Post",
            "Test"});
            this.clbTables.Location = new System.Drawing.Point(90, 68);
            this.clbTables.Name = "clbTables";
            this.clbTables.Size = new System.Drawing.Size(150, 128);
            this.clbTables.Sorted = true;
            this.clbTables.TabIndex = 7;
            // 
            // lblTables
            // 
            this.lblTables.AutoSize = true;
            this.lblTables.Location = new System.Drawing.Point(13, 68);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(43, 15);
            this.lblTables.TabIndex = 6;
            this.lblTables.Text = "Tables:";
            // 
            // cmbSqlDatabases
            // 
            this.cmbSqlDatabases.FormattingEnabled = true;
            this.cmbSqlDatabases.Location = new System.Drawing.Point(90, 38);
            this.cmbSqlDatabases.Name = "cmbSqlDatabases";
            this.cmbSqlDatabases.Size = new System.Drawing.Size(150, 23);
            this.cmbSqlDatabases.TabIndex = 5;
            this.cmbSqlDatabases.SelectedIndexChanged += new System.EventHandler(this.cmbSqlDatabases_SelectedIndexChanged);
            // 
            // lblDatabases
            // 
            this.lblDatabases.AutoSize = true;
            this.lblDatabases.Location = new System.Drawing.Point(13, 42);
            this.lblDatabases.Name = "lblDatabases";
            this.lblDatabases.Size = new System.Drawing.Size(63, 15);
            this.lblDatabases.TabIndex = 4;
            this.lblDatabases.Text = "Databases:";
            // 
            // cmbSqlServers
            // 
            this.cmbSqlServers.FormattingEnabled = true;
            this.cmbSqlServers.Location = new System.Drawing.Point(90, 9);
            this.cmbSqlServers.Name = "cmbSqlServers";
            this.cmbSqlServers.Size = new System.Drawing.Size(150, 23);
            this.cmbSqlServers.TabIndex = 3;
            this.cmbSqlServers.SelectedIndexChanged += new System.EventHandler(this.cmbSqlServers_SelectedIndexChanged);
            // 
            // lblSqlServer
            // 
            this.lblSqlServer.AutoSize = true;
            this.lblSqlServer.Location = new System.Drawing.Point(13, 12);
            this.lblSqlServer.Name = "lblSqlServer";
            this.lblSqlServer.Size = new System.Drawing.Size(71, 15);
            this.lblSqlServer.TabIndex = 2;
            this.lblSqlServer.Text = "SQL Servers:";
            // 
            // wpMySqlSettings
            // 
            this.wpMySqlSettings.Controls.Add(this.pnlMySqlDisplay);
            this.wpMySqlSettings.Name = "wpMySqlSettings";
            this.wpMySqlSettings.Size = new System.Drawing.Size(437, 207);
            this.wpMySqlSettings.TabIndex = 1;
            this.wpMySqlSettings.Text = "MySql Settings";
            // 
            // cbIncludeSP
            // 
            this.cbIncludeSP.AutoSize = true;
            this.cbIncludeSP.Location = new System.Drawing.Point(261, 93);
            this.cbIncludeSP.Name = "cbIncludeSP";
            this.cbIncludeSP.Size = new System.Drawing.Size(164, 19);
            this.cbIncludeSP.TabIndex = 10;
            this.cbIncludeSP.Text = "Include Stored Procedures";
            this.cbIncludeSP.UseVisualStyleBackColor = true;
            // 
            // cbIncludeFunctions
            // 
            this.cbIncludeFunctions.AutoSize = true;
            this.cbIncludeFunctions.Location = new System.Drawing.Point(261, 67);
            this.cbIncludeFunctions.Name = "cbIncludeFunctions";
            this.cbIncludeFunctions.Size = new System.Drawing.Size(120, 19);
            this.cbIncludeFunctions.TabIndex = 11;
            this.cbIncludeFunctions.Text = "Include Functions";
            this.cbIncludeFunctions.UseVisualStyleBackColor = true;
            // 
            // cbIncludeTriggers
            // 
            this.cbIncludeTriggers.AutoSize = true;
            this.cbIncludeTriggers.Location = new System.Drawing.Point(261, 119);
            this.cbIncludeTriggers.Name = "cbIncludeTriggers";
            this.cbIncludeTriggers.Size = new System.Drawing.Size(110, 19);
            this.cbIncludeTriggers.TabIndex = 12;
            this.cbIncludeTriggers.Text = "Include Triggers";
            this.cbIncludeTriggers.UseVisualStyleBackColor = true;
            // 
            // cbIncludeViews
            // 
            this.cbIncludeViews.AutoSize = true;
            this.cbIncludeViews.Location = new System.Drawing.Point(261, 145);
            this.cbIncludeViews.Name = "cbIncludeViews";
            this.cbIncludeViews.Size = new System.Drawing.Size(98, 19);
            this.cbIncludeViews.TabIndex = 13;
            this.cbIncludeViews.Text = "Include Views";
            this.cbIncludeViews.UseVisualStyleBackColor = true;
            // 
            // pnlMySqlDisplay
            // 
            this.pnlMySqlDisplay.Controls.Add(this.label4);
            this.pnlMySqlDisplay.Controls.Add(this.txtCustomName);
            this.pnlMySqlDisplay.Controls.Add(this.cbCustomName);
            this.pnlMySqlDisplay.Controls.Add(this.label2);
            this.pnlMySqlDisplay.Controls.Add(this.label1);
            this.pnlMySqlDisplay.Controls.Add(this.cmbMySqlServers);
            this.pnlMySqlDisplay.Controls.Add(this.label3);
            this.pnlMySqlDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMySqlDisplay.Location = new System.Drawing.Point(0, 0);
            this.pnlMySqlDisplay.Name = "pnlMySqlDisplay";
            this.pnlMySqlDisplay.Size = new System.Drawing.Size(437, 207);
            this.pnlMySqlDisplay.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Custom Name:";
            // 
            // txtCustomName
            // 
            this.txtCustomName.Enabled = false;
            this.txtCustomName.Location = new System.Drawing.Point(145, 125);
            this.txtCustomName.Name = "txtCustomName";
            this.txtCustomName.Size = new System.Drawing.Size(150, 23);
            this.txtCustomName.TabIndex = 17;
            // 
            // cbCustomName
            // 
            this.cbCustomName.AutoSize = true;
            this.cbCustomName.Checked = true;
            this.cbCustomName.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbCustomName.Location = new System.Drawing.Point(31, 98);
            this.cbCustomName.Name = "cbCustomName";
            this.cbCustomName.Size = new System.Drawing.Size(141, 19);
            this.cbCustomName.TabIndex = 16;
            this.cbCustomName.Text = "Specify another name";
            this.cbCustomName.UseVisualStyleBackColor = true;
            this.cbCustomName.CheckedChanged += new System.EventHandler(this.cbCustomName_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "If you would like to specify another name, please select the box below:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Please note that a new database will be created on MySql.";
            // 
            // cmbMySqlServers
            // 
            this.cmbMySqlServers.FormattingEnabled = true;
            this.cmbMySqlServers.Location = new System.Drawing.Point(102, 9);
            this.cmbMySqlServers.Name = "cmbMySqlServers";
            this.cmbMySqlServers.Size = new System.Drawing.Size(150, 23);
            this.cmbMySqlServers.TabIndex = 13;
            this.cmbMySqlServers.SelectedIndexChanged += new System.EventHandler(this.cmbMySqlServers_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "MySql Servers:";
            // 
            // frmWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.wcServerSettings);
            this.Name = "frmWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wizard";
            this.Load += new System.EventHandler(this.frmWizard_Load);
            this.Shown += new System.EventHandler(this.frmWizard_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.wcServerSettings)).EndInit();
            this.wpSqlServerSettings.ResumeLayout(false);
            this.mpSqlServerDisplay.ResumeLayout(false);
            this.mpSqlServerDisplay.PerformLayout();
            this.wpMySqlSettings.ResumeLayout(false);
            this.pnlMySqlDisplay.ResumeLayout(false);
            this.pnlMySqlDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl wcServerSettings;
        private AeroWizard.WizardPage wpSqlServerSettings;
        private AeroWizard.WizardPage wpMySqlSettings;
        private MetroFramework.Controls.MetroPanel mpSqlServerDisplay;
        private System.Windows.Forms.ComboBox cmbSqlDatabases;
        private System.Windows.Forms.Label lblDatabases;
        private System.Windows.Forms.ComboBox cmbSqlServers;
        private System.Windows.Forms.Label lblSqlServer;
        private System.Windows.Forms.Label lblTables;
        private System.Windows.Forms.CheckedListBox clbTables;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox cbIncludeSP;
        private System.Windows.Forms.CheckBox cbIncludeFunctions;
        private System.Windows.Forms.CheckBox cbIncludeViews;
        private System.Windows.Forms.CheckBox cbIncludeTriggers;
        private System.Windows.Forms.Panel pnlMySqlDisplay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomName;
        private System.Windows.Forms.CheckBox cbCustomName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMySqlServers;
        private System.Windows.Forms.Label label3;
    }
}