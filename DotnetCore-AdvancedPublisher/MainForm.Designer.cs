namespace DotnetCoreAdvancedPublisher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.m_textBoxProjectPath = new System.Windows.Forms.TextBox();
            this.m_textBoxOutputPath = new System.Windows.Forms.TextBox();
            this.m_comboBoxPublishType = new System.Windows.Forms.ComboBox();
            this.m_comboBoxTargetPlatform = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_comboBoxRID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_buttonPublish = new System.Windows.Forms.Button();
            this.m_ofdSelectProject = new System.Windows.Forms.OpenFileDialog();
            this.m_fbdOutputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.m_checkBoxReadyToRun = new System.Windows.Forms.CheckBox();
            this.m_checkBoxSingleFile = new System.Windows.Forms.CheckBox();
            this.m_checkBoxPublishTrimmer = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_pictureBoxGithubLink = new System.Windows.Forms.PictureBox();
            this.m_labelVersion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxGithubLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // m_textBoxProjectPath
            // 
            this.m_textBoxProjectPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_textBoxProjectPath.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.m_textBoxProjectPath.Location = new System.Drawing.Point(12, 301);
            this.m_textBoxProjectPath.Name = "m_textBoxProjectPath";
            this.m_textBoxProjectPath.ReadOnly = true;
            this.m_textBoxProjectPath.Size = new System.Drawing.Size(468, 25);
            this.m_textBoxProjectPath.TabIndex = 6;
            this.m_textBoxProjectPath.Click += new System.EventHandler(this.m_textBoxProjectPath_Click);
            // 
            // m_textBoxOutputPath
            // 
            this.m_textBoxOutputPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_textBoxOutputPath.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.m_textBoxOutputPath.Location = new System.Drawing.Point(13, 369);
            this.m_textBoxOutputPath.Name = "m_textBoxOutputPath";
            this.m_textBoxOutputPath.ReadOnly = true;
            this.m_textBoxOutputPath.Size = new System.Drawing.Size(467, 25);
            this.m_textBoxOutputPath.TabIndex = 7;
            this.m_textBoxOutputPath.Click += new System.EventHandler(this.m_textBoxOutputPath_Click);
            // 
            // m_comboBoxPublishType
            // 
            this.m_comboBoxPublishType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_comboBoxPublishType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.m_comboBoxPublishType.FormattingEnabled = true;
            this.m_comboBoxPublishType.Items.AddRange(new object[] {
            "Framework Dependent",
            "Self-Contained"});
            this.m_comboBoxPublishType.Location = new System.Drawing.Point(12, 137);
            this.m_comboBoxPublishType.Name = "m_comboBoxPublishType";
            this.m_comboBoxPublishType.Size = new System.Drawing.Size(176, 25);
            this.m_comboBoxPublishType.TabIndex = 0;
            this.m_comboBoxPublishType.SelectedIndexChanged += new System.EventHandler(this.m_comboBoxPublishType_SelectedIndexChanged);
            // 
            // m_comboBoxTargetPlatform
            // 
            this.m_comboBoxTargetPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_comboBoxTargetPlatform.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.m_comboBoxTargetPlatform.FormattingEnabled = true;
            this.m_comboBoxTargetPlatform.Items.AddRange(new object[] {
            "Windows",
            "Linux ",
            "MacOS"});
            this.m_comboBoxTargetPlatform.Location = new System.Drawing.Point(194, 137);
            this.m_comboBoxTargetPlatform.Name = "m_comboBoxTargetPlatform";
            this.m_comboBoxTargetPlatform.Size = new System.Drawing.Size(130, 25);
            this.m_comboBoxTargetPlatform.TabIndex = 1;
            this.m_comboBoxTargetPlatform.SelectedIndexChanged += new System.EventHandler(this.m_comboBoxTargetPlatform_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Publish Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(191, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Target Platform :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(327, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Runtime Identifier (RID) :";
            // 
            // m_comboBoxRID
            // 
            this.m_comboBoxRID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_comboBoxRID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.m_comboBoxRID.FormattingEnabled = true;
            this.m_comboBoxRID.Items.AddRange(new object[] {
            "win-x64"});
            this.m_comboBoxRID.Location = new System.Drawing.Point(330, 137);
            this.m_comboBoxRID.Name = "m_comboBoxRID";
            this.m_comboBoxRID.Size = new System.Drawing.Size(153, 25);
            this.m_comboBoxRID.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label4.Location = new System.Drawing.Point(9, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select Output Project Folder :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label5.Location = new System.Drawing.Point(9, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Select Project File :";
            // 
            // m_buttonPublish
            // 
            this.m_buttonPublish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(30)))), ((int)(((byte)(229)))));
            this.m_buttonPublish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_buttonPublish.FlatAppearance.BorderSize = 0;
            this.m_buttonPublish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_buttonPublish.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.m_buttonPublish.ForeColor = System.Drawing.Color.White;
            this.m_buttonPublish.Location = new System.Drawing.Point(13, 409);
            this.m_buttonPublish.Name = "m_buttonPublish";
            this.m_buttonPublish.Size = new System.Drawing.Size(467, 42);
            this.m_buttonPublish.TabIndex = 8;
            this.m_buttonPublish.Text = "PUBLISH";
            this.m_buttonPublish.UseVisualStyleBackColor = false;
            this.m_buttonPublish.Click += new System.EventHandler(this.m_buttonPublish_Click);
            // 
            // m_checkBoxReadyToRun
            // 
            this.m_checkBoxReadyToRun.AutoSize = true;
            this.m_checkBoxReadyToRun.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.m_checkBoxReadyToRun.Location = new System.Drawing.Point(12, 179);
            this.m_checkBoxReadyToRun.Name = "m_checkBoxReadyToRun";
            this.m_checkBoxReadyToRun.Size = new System.Drawing.Size(214, 21);
            this.m_checkBoxReadyToRun.TabIndex = 3;
            this.m_checkBoxReadyToRun.Text = "Enable ReadyToRun compilation";
            this.m_checkBoxReadyToRun.UseVisualStyleBackColor = true;
            // 
            // m_checkBoxSingleFile
            // 
            this.m_checkBoxSingleFile.AutoSize = true;
            this.m_checkBoxSingleFile.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.m_checkBoxSingleFile.Location = new System.Drawing.Point(12, 206);
            this.m_checkBoxSingleFile.Name = "m_checkBoxSingleFile";
            this.m_checkBoxSingleFile.Size = new System.Drawing.Size(134, 21);
            this.m_checkBoxSingleFile.TabIndex = 4;
            this.m_checkBoxSingleFile.Text = "Produce single file";
            this.m_checkBoxSingleFile.UseVisualStyleBackColor = true;
            // 
            // m_checkBoxPublishTrimmer
            // 
            this.m_checkBoxPublishTrimmer.AutoSize = true;
            this.m_checkBoxPublishTrimmer.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.m_checkBoxPublishTrimmer.Location = new System.Drawing.Point(12, 233);
            this.m_checkBoxPublishTrimmer.Name = "m_checkBoxPublishTrimmer";
            this.m_checkBoxPublishTrimmer.Size = new System.Drawing.Size(129, 21);
            this.m_checkBoxPublishTrimmer.TabIndex = 5;
            this.m_checkBoxPublishTrimmer.Text = "Trim unused DLLs";
            this.m_checkBoxPublishTrimmer.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.m_pictureBoxGithubLink);
            this.panel1.Controls.Add(this.m_labelVersion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 28);
            this.panel1.TabIndex = 15;
            // 
            // m_pictureBoxGithubLink
            // 
            this.m_pictureBoxGithubLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_pictureBoxGithubLink.Image = global::DotnetCoreAdvancedPublisher.Properties.Resources.github;
            this.m_pictureBoxGithubLink.Location = new System.Drawing.Point(11, 4);
            this.m_pictureBoxGithubLink.Name = "m_pictureBoxGithubLink";
            this.m_pictureBoxGithubLink.Size = new System.Drawing.Size(20, 20);
            this.m_pictureBoxGithubLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_pictureBoxGithubLink.TabIndex = 16;
            this.m_pictureBoxGithubLink.TabStop = false;
            this.m_pictureBoxGithubLink.Click += new System.EventHandler(this.m_pictureBoxGithubLink_Click);
            // 
            // m_labelVersion
            // 
            this.m_labelVersion.AutoSize = true;
            this.m_labelVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.m_labelVersion.Location = new System.Drawing.Point(450, 5);
            this.m_labelVersion.Name = "m_labelVersion";
            this.m_labelVersion.Size = new System.Drawing.Size(45, 17);
            this.m_labelVersion.TabIndex = 17;
            this.m_labelVersion.Text = "1.0.0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label6.Location = new System.Drawing.Point(173, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "All rights are free. | 2021";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::DotnetCoreAdvancedPublisher.Properties.Resources.header3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_checkBoxPublishTrimmer);
            this.Controls.Add(this.m_checkBoxSingleFile);
            this.Controls.Add(this.m_checkBoxReadyToRun);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.m_buttonPublish);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_comboBoxRID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_comboBoxTargetPlatform);
            this.Controls.Add(this.m_comboBoxPublishType);
            this.Controls.Add(this.m_textBoxOutputPath);
            this.Controls.Add(this.m_textBoxProjectPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".NET Core Advanced Publisher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_pictureBoxGithubLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_textBoxProjectPath;
        private System.Windows.Forms.TextBox m_textBoxOutputPath;
        private System.Windows.Forms.ComboBox m_comboBoxPublishType;
        private System.Windows.Forms.ComboBox m_comboBoxTargetPlatform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox m_comboBoxRID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button m_buttonPublish;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog m_ofdSelectProject;
        private System.Windows.Forms.FolderBrowserDialog m_fbdOutputFolder;
        private System.Windows.Forms.CheckBox m_checkBoxReadyToRun;
        private System.Windows.Forms.CheckBox m_checkBoxSingleFile;
        private System.Windows.Forms.CheckBox m_checkBoxPublishTrimmer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label m_labelVersion;
        private System.Windows.Forms.PictureBox m_pictureBoxGithubLink;
        private System.Windows.Forms.Label label6;
    }
}

