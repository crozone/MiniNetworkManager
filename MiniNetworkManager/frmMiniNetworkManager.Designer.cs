namespace MiniNetworkManager
{
    partial class frmMiniNetworkManager
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
            this.lstNetworks = new System.Windows.Forms.ListBox();
            this.grpNetworkDetails = new System.Windows.Forms.GroupBox();
            this.lblSaveResult = new System.Windows.Forms.Label();
            this.btnNetworkSave = new System.Windows.Forms.Button();
            this.nudNetworkNameType = new System.Windows.Forms.NumericUpDown();
            this.cmbNetworkCategory = new System.Windows.Forms.ComboBox();
            this.lblNetworkNameType = new System.Windows.Forms.Label();
            this.lblNetworkCategory = new System.Windows.Forms.Label();
            this.lblNetworkDescription = new System.Windows.Forms.Label();
            this.txtNetworkDescription = new System.Windows.Forms.TextBox();
            this.lblNetworkProfileName = new System.Windows.Forms.Label();
            this.txtNetworkProfileName = new System.Windows.Forms.TextBox();
            this.lblNetworkId = new System.Windows.Forms.Label();
            this.txtNetworkId = new System.Windows.Forms.TextBox();
            this.grpNetworks = new System.Windows.Forms.GroupBox();
            this.btnRefreshNetworks = new System.Windows.Forms.Button();
            this.btnNetworkDelete = new System.Windows.Forms.Button();
            this.splMainUi = new System.Windows.Forms.SplitContainer();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpNetworkDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNetworkNameType)).BeginInit();
            this.grpNetworks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splMainUi)).BeginInit();
            this.splMainUi.Panel1.SuspendLayout();
            this.splMainUi.Panel2.SuspendLayout();
            this.splMainUi.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstNetworks
            // 
            this.lstNetworks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstNetworks.FormattingEnabled = true;
            this.lstNetworks.ItemHeight = 16;
            this.lstNetworks.Location = new System.Drawing.Point(3, 59);
            this.lstNetworks.Name = "lstNetworks";
            this.lstNetworks.Size = new System.Drawing.Size(479, 356);
            this.lstNetworks.TabIndex = 0;
            this.lstNetworks.SelectedValueChanged += new System.EventHandler(this.lstNetworks_SelectedValueChanged);
            // 
            // grpNetworkDetails
            // 
            this.grpNetworkDetails.Controls.Add(this.btnNetworkDelete);
            this.grpNetworkDetails.Controls.Add(this.lblSaveResult);
            this.grpNetworkDetails.Controls.Add(this.btnNetworkSave);
            this.grpNetworkDetails.Controls.Add(this.nudNetworkNameType);
            this.grpNetworkDetails.Controls.Add(this.cmbNetworkCategory);
            this.grpNetworkDetails.Controls.Add(this.lblNetworkNameType);
            this.grpNetworkDetails.Controls.Add(this.lblNetworkCategory);
            this.grpNetworkDetails.Controls.Add(this.lblNetworkDescription);
            this.grpNetworkDetails.Controls.Add(this.txtNetworkDescription);
            this.grpNetworkDetails.Controls.Add(this.lblNetworkProfileName);
            this.grpNetworkDetails.Controls.Add(this.txtNetworkProfileName);
            this.grpNetworkDetails.Controls.Add(this.lblNetworkId);
            this.grpNetworkDetails.Controls.Add(this.txtNetworkId);
            this.grpNetworkDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNetworkDetails.Location = new System.Drawing.Point(0, 0);
            this.grpNetworkDetails.Name = "grpNetworkDetails";
            this.grpNetworkDetails.Size = new System.Drawing.Size(479, 422);
            this.grpNetworkDetails.TabIndex = 1;
            this.grpNetworkDetails.TabStop = false;
            this.grpNetworkDetails.Text = "Network Details";
            // 
            // lblSaveResult
            // 
            this.lblSaveResult.AutoSize = true;
            this.lblSaveResult.Location = new System.Drawing.Point(111, 292);
            this.lblSaveResult.Name = "lblSaveResult";
            this.lblSaveResult.Size = new System.Drawing.Size(84, 17);
            this.lblSaveResult.TabIndex = 15;
            this.lblSaveResult.Text = "Save Result";
            // 
            // btnNetworkSave
            // 
            this.btnNetworkSave.Location = new System.Drawing.Point(108, 234);
            this.btnNetworkSave.Name = "btnNetworkSave";
            this.btnNetworkSave.Size = new System.Drawing.Size(100, 31);
            this.btnNetworkSave.TabIndex = 14;
            this.btnNetworkSave.Text = "Save";
            this.btnNetworkSave.UseVisualStyleBackColor = true;
            this.btnNetworkSave.Click += new System.EventHandler(this.btnNetworkSave_Click);
            // 
            // nudNetworkNameType
            // 
            this.nudNetworkNameType.Location = new System.Drawing.Point(108, 191);
            this.nudNetworkNameType.Name = "nudNetworkNameType";
            this.nudNetworkNameType.Size = new System.Drawing.Size(358, 22);
            this.nudNetworkNameType.TabIndex = 13;
            // 
            // cmbNetworkCategory
            // 
            this.cmbNetworkCategory.FormattingEnabled = true;
            this.cmbNetworkCategory.Location = new System.Drawing.Point(108, 158);
            this.cmbNetworkCategory.Name = "cmbNetworkCategory";
            this.cmbNetworkCategory.Size = new System.Drawing.Size(358, 24);
            this.cmbNetworkCategory.TabIndex = 12;
            // 
            // lblNetworkNameType
            // 
            this.lblNetworkNameType.AutoSize = true;
            this.lblNetworkNameType.Location = new System.Drawing.Point(6, 191);
            this.lblNetworkNameType.Name = "lblNetworkNameType";
            this.lblNetworkNameType.Size = new System.Drawing.Size(85, 17);
            this.lblNetworkNameType.TabIndex = 9;
            this.lblNetworkNameType.Text = "Name Type:";
            // 
            // lblNetworkCategory
            // 
            this.lblNetworkCategory.AutoSize = true;
            this.lblNetworkCategory.Location = new System.Drawing.Point(6, 163);
            this.lblNetworkCategory.Name = "lblNetworkCategory";
            this.lblNetworkCategory.Size = new System.Drawing.Size(69, 17);
            this.lblNetworkCategory.TabIndex = 7;
            this.lblNetworkCategory.Text = "Category:";
            // 
            // lblNetworkDescription
            // 
            this.lblNetworkDescription.AutoSize = true;
            this.lblNetworkDescription.Location = new System.Drawing.Point(6, 135);
            this.lblNetworkDescription.Name = "lblNetworkDescription";
            this.lblNetworkDescription.Size = new System.Drawing.Size(83, 17);
            this.lblNetworkDescription.TabIndex = 5;
            this.lblNetworkDescription.Text = "Description:";
            // 
            // txtNetworkDescription
            // 
            this.txtNetworkDescription.Location = new System.Drawing.Point(108, 132);
            this.txtNetworkDescription.Name = "txtNetworkDescription";
            this.txtNetworkDescription.Size = new System.Drawing.Size(358, 22);
            this.txtNetworkDescription.TabIndex = 4;
            // 
            // lblNetworkProfileName
            // 
            this.lblNetworkProfileName.AutoSize = true;
            this.lblNetworkProfileName.Location = new System.Drawing.Point(6, 107);
            this.lblNetworkProfileName.Name = "lblNetworkProfileName";
            this.lblNetworkProfileName.Size = new System.Drawing.Size(93, 17);
            this.lblNetworkProfileName.TabIndex = 3;
            this.lblNetworkProfileName.Text = "Profile Name:";
            // 
            // txtNetworkProfileName
            // 
            this.txtNetworkProfileName.Location = new System.Drawing.Point(108, 104);
            this.txtNetworkProfileName.Name = "txtNetworkProfileName";
            this.txtNetworkProfileName.Size = new System.Drawing.Size(358, 22);
            this.txtNetworkProfileName.TabIndex = 2;
            // 
            // lblNetworkId
            // 
            this.lblNetworkId.AutoSize = true;
            this.lblNetworkId.Location = new System.Drawing.Point(6, 79);
            this.lblNetworkId.Name = "lblNetworkId";
            this.lblNetworkId.Size = new System.Drawing.Size(23, 17);
            this.lblNetworkId.TabIndex = 1;
            this.lblNetworkId.Text = "Id:";
            // 
            // txtNetworkId
            // 
            this.txtNetworkId.Location = new System.Drawing.Point(108, 76);
            this.txtNetworkId.Name = "txtNetworkId";
            this.txtNetworkId.Size = new System.Drawing.Size(358, 22);
            this.txtNetworkId.TabIndex = 0;
            // 
            // grpNetworks
            // 
            this.grpNetworks.Controls.Add(this.btnRefreshNetworks);
            this.grpNetworks.Controls.Add(this.lstNetworks);
            this.grpNetworks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNetworks.Location = new System.Drawing.Point(0, 0);
            this.grpNetworks.Name = "grpNetworks";
            this.grpNetworks.Size = new System.Drawing.Size(488, 422);
            this.grpNetworks.TabIndex = 2;
            this.grpNetworks.TabStop = false;
            this.grpNetworks.Text = "Networks";
            // 
            // btnRefreshNetworks
            // 
            this.btnRefreshNetworks.Location = new System.Drawing.Point(3, 21);
            this.btnRefreshNetworks.Name = "btnRefreshNetworks";
            this.btnRefreshNetworks.Size = new System.Drawing.Size(169, 32);
            this.btnRefreshNetworks.TabIndex = 1;
            this.btnRefreshNetworks.Text = "Refresh";
            this.btnRefreshNetworks.UseVisualStyleBackColor = true;
            this.btnRefreshNetworks.Click += new System.EventHandler(this.btnRefreshNetworks_Click);
            // 
            // btnNetworkDelete
            // 
            this.btnNetworkDelete.Location = new System.Drawing.Point(360, 234);
            this.btnNetworkDelete.Name = "btnNetworkDelete";
            this.btnNetworkDelete.Size = new System.Drawing.Size(106, 31);
            this.btnNetworkDelete.TabIndex = 16;
            this.btnNetworkDelete.Text = "Delete";
            this.btnNetworkDelete.UseVisualStyleBackColor = true;
            this.btnNetworkDelete.Click += new System.EventHandler(this.btnNetworkDelete_Click);
            // 
            // splMainUi
            // 
            this.splMainUi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splMainUi.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splMainUi.Location = new System.Drawing.Point(0, 28);
            this.splMainUi.Name = "splMainUi";
            // 
            // splMainUi.Panel1
            // 
            this.splMainUi.Panel1.Controls.Add(this.grpNetworks);
            // 
            // splMainUi.Panel2
            // 
            this.splMainUi.Panel2.Controls.Add(this.grpNetworkDetails);
            this.splMainUi.Size = new System.Drawing.Size(971, 422);
            this.splMainUi.SplitterDistance = 488;
            this.splMainUi.TabIndex = 3;
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuMain.Size = new System.Drawing.Size(971, 28);
            this.menuMain.TabIndex = 4;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmMiniNetworkManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 450);
            this.Controls.Add(this.splMainUi);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMiniNetworkManager";
            this.Text = "Mini Network Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpNetworkDetails.ResumeLayout(false);
            this.grpNetworkDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNetworkNameType)).EndInit();
            this.grpNetworks.ResumeLayout(false);
            this.splMainUi.Panel1.ResumeLayout(false);
            this.splMainUi.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splMainUi)).EndInit();
            this.splMainUi.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNetworks;
        private System.Windows.Forms.GroupBox grpNetworkDetails;
        private System.Windows.Forms.GroupBox grpNetworks;
        private System.Windows.Forms.Button btnRefreshNetworks;
        private System.Windows.Forms.Label lblNetworkNameType;
        private System.Windows.Forms.Label lblNetworkCategory;
        private System.Windows.Forms.Label lblNetworkDescription;
        private System.Windows.Forms.TextBox txtNetworkDescription;
        private System.Windows.Forms.Label lblNetworkProfileName;
        private System.Windows.Forms.TextBox txtNetworkProfileName;
        private System.Windows.Forms.Label lblNetworkId;
        private System.Windows.Forms.TextBox txtNetworkId;
        private System.Windows.Forms.NumericUpDown nudNetworkNameType;
        private System.Windows.Forms.ComboBox cmbNetworkCategory;
        private System.Windows.Forms.Button btnNetworkSave;
        private System.Windows.Forms.Label lblSaveResult;
        private System.Windows.Forms.Button btnNetworkDelete;
        private System.Windows.Forms.SplitContainer splMainUi;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

