﻿namespace PacketViewerLogViewer
{
    partial class ProjectInfoForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectInfoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tProjectFolder = new System.Windows.Forms.TextBox();
            this.tOpenedLog = new System.Windows.Forms.TextBox();
            this.tSourceVideo = new System.Windows.Forms.TextBox();
            this.tYoutubeURL = new System.Windows.Forms.TextBox();
            this.tPackedLogsURL = new System.Windows.Forms.TextBox();
            this.saveProjectDlg = new System.Windows.Forms.SaveFileDialog();
            this.btnDownloadSource = new System.Windows.Forms.Button();
            this.IL = new System.Windows.Forms.ImageList(this.components);
            this.btnDownloadYoutube = new System.Windows.Forms.Button();
            this.btnUploadToYoutube = new System.Windows.Forms.Button();
            this.gbLocalFiles = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lVideoSourceOK = new System.Windows.Forms.Label();
            this.lOpenedLogOK = new System.Windows.Forms.Label();
            this.lProjectFolderOK = new System.Windows.Forms.Label();
            this.btnExtractZip = new System.Windows.Forms.Button();
            this.btnMake7zip = new System.Windows.Forms.Button();
            this.gbOnlineFile = new System.Windows.Forms.GroupBox();
            this.gbProjectInfo = new System.Windows.Forms.GroupBox();
            this.tTagBox = new System.Windows.Forms.TextBox();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.tagContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lTagLabel = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCopySummary = new System.Windows.Forms.Button();
            this.tcProjectInfo = new System.Windows.Forms.TabControl();
            this.tpMainInfo = new System.Windows.Forms.TabPage();
            this.tlProjectInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tlCommunity = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lCurrentArchiveName = new System.Windows.Forms.Label();
            this.btnUploadLogs = new System.Windows.Forms.Button();
            this.gbLocalFiles.SuspendLayout();
            this.gbOnlineFile.SuspendLayout();
            this.gbProjectInfo.SuspendLayout();
            this.tagContainer.SuspendLayout();
            this.tcProjectInfo.SuspendLayout();
            this.tpMainInfo.SuspendLayout();
            this.tlProjectInfo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tlCommunity.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Associated Log file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Folder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Local Video Link";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Youtube URL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Download URL";
            // 
            // tProjectFolder
            // 
            this.tProjectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tProjectFolder.Location = new System.Drawing.Point(20, 32);
            this.tProjectFolder.Name = "tProjectFolder";
            this.tProjectFolder.ReadOnly = true;
            this.tProjectFolder.Size = new System.Drawing.Size(507, 20);
            this.tProjectFolder.TabIndex = 2;
            this.tProjectFolder.TextChanged += new System.EventHandler(this.ProjectInfo_TextChanged);
            // 
            // tOpenedLog
            // 
            this.tOpenedLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tOpenedLog.Location = new System.Drawing.Point(20, 71);
            this.tOpenedLog.Name = "tOpenedLog";
            this.tOpenedLog.ReadOnly = true;
            this.tOpenedLog.Size = new System.Drawing.Size(507, 20);
            this.tOpenedLog.TabIndex = 3;
            this.tOpenedLog.TextChanged += new System.EventHandler(this.ProjectInfo_TextChanged);
            // 
            // tSourceVideo
            // 
            this.tSourceVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tSourceVideo.Location = new System.Drawing.Point(20, 110);
            this.tSourceVideo.Name = "tSourceVideo";
            this.tSourceVideo.ReadOnly = true;
            this.tSourceVideo.Size = new System.Drawing.Size(507, 20);
            this.tSourceVideo.TabIndex = 4;
            this.tSourceVideo.TextChanged += new System.EventHandler(this.ProjectInfo_TextChanged);
            // 
            // tYoutubeURL
            // 
            this.tYoutubeURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tYoutubeURL.Location = new System.Drawing.Point(20, 32);
            this.tYoutubeURL.Name = "tYoutubeURL";
            this.tYoutubeURL.Size = new System.Drawing.Size(406, 20);
            this.tYoutubeURL.TabIndex = 5;
            this.tYoutubeURL.TextChanged += new System.EventHandler(this.ProjectInfo_TextChanged);
            // 
            // tPackedLogsURL
            // 
            this.tPackedLogsURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tPackedLogsURL.Location = new System.Drawing.Point(20, 71);
            this.tPackedLogsURL.Name = "tPackedLogsURL";
            this.tPackedLogsURL.Size = new System.Drawing.Size(406, 20);
            this.tPackedLogsURL.TabIndex = 6;
            this.tPackedLogsURL.TextChanged += new System.EventHandler(this.ProjectInfo_TextChanged);
            // 
            // saveProjectDlg
            // 
            this.saveProjectDlg.DefaultExt = "pvlv";
            this.saveProjectDlg.Filter = "PVLV Project Files (*.pvlv)|*.pvlv|All files|*.*";
            // 
            // btnDownloadSource
            // 
            this.btnDownloadSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadSource.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadSource.ImageIndex = 2;
            this.btnDownloadSource.ImageList = this.IL;
            this.btnDownloadSource.Location = new System.Drawing.Point(432, 69);
            this.btnDownloadSource.Name = "btnDownloadSource";
            this.btnDownloadSource.Size = new System.Drawing.Size(123, 23);
            this.btnDownloadSource.TabIndex = 11;
            this.btnDownloadSource.Text = "Download";
            this.btnDownloadSource.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDownloadSource.UseVisualStyleBackColor = true;
            this.btnDownloadSource.Click += new System.EventHandler(this.BtnDownloadSource_Click);
            // 
            // IL
            // 
            this.IL.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IL.ImageStream")));
            this.IL.TransparentColor = System.Drawing.Color.Transparent;
            this.IL.Images.SetKeyName(0, "Fairytale_ark.png");
            this.IL.Images.SetKeyName(1, "Fairytale_upload.png");
            this.IL.Images.SetKeyName(2, "Fairytale_browser.png");
            this.IL.Images.SetKeyName(3, "Fairytale_editcopy.png");
            this.IL.Images.SetKeyName(4, "Fairytale_apply.png");
            this.IL.Images.SetKeyName(5, "Fairytale_fileopen.png");
            this.IL.Images.SetKeyName(6, "5700.add.png");
            // 
            // btnDownloadYoutube
            // 
            this.btnDownloadYoutube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownloadYoutube.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadYoutube.ImageIndex = 2;
            this.btnDownloadYoutube.ImageList = this.IL;
            this.btnDownloadYoutube.Location = new System.Drawing.Point(432, 32);
            this.btnDownloadYoutube.Name = "btnDownloadYoutube";
            this.btnDownloadYoutube.Size = new System.Drawing.Size(123, 23);
            this.btnDownloadYoutube.TabIndex = 12;
            this.btnDownloadYoutube.Text = "Open in browser";
            this.btnDownloadYoutube.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDownloadYoutube.UseVisualStyleBackColor = true;
            this.btnDownloadYoutube.Click += new System.EventHandler(this.BtnDownloadYoutube_Click);
            // 
            // btnUploadToYoutube
            // 
            this.btnUploadToYoutube.Enabled = false;
            this.btnUploadToYoutube.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadToYoutube.ImageIndex = 1;
            this.btnUploadToYoutube.ImageList = this.IL;
            this.btnUploadToYoutube.Location = new System.Drawing.Point(9, 77);
            this.btnUploadToYoutube.Name = "btnUploadToYoutube";
            this.btnUploadToYoutube.Size = new System.Drawing.Size(160, 23);
            this.btnUploadToYoutube.TabIndex = 14;
            this.btnUploadToYoutube.Text = "Upload Video to Youtube";
            this.btnUploadToYoutube.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUploadToYoutube.UseVisualStyleBackColor = true;
            this.btnUploadToYoutube.Click += new System.EventHandler(this.BtnUploadToYoutube_Click);
            // 
            // gbLocalFiles
            // 
            this.gbLocalFiles.Controls.Add(this.label7);
            this.gbLocalFiles.Controls.Add(this.lVideoSourceOK);
            this.gbLocalFiles.Controls.Add(this.lOpenedLogOK);
            this.gbLocalFiles.Controls.Add(this.lProjectFolderOK);
            this.gbLocalFiles.Controls.Add(this.label2);
            this.gbLocalFiles.Controls.Add(this.label1);
            this.gbLocalFiles.Controls.Add(this.label3);
            this.gbLocalFiles.Controls.Add(this.tProjectFolder);
            this.gbLocalFiles.Controls.Add(this.tOpenedLog);
            this.gbLocalFiles.Controls.Add(this.tSourceVideo);
            this.gbLocalFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLocalFiles.Location = new System.Drawing.Point(3, 3);
            this.gbLocalFiles.Name = "gbLocalFiles";
            this.gbLocalFiles.Size = new System.Drawing.Size(564, 162);
            this.gbLocalFiles.TabIndex = 15;
            this.gbLocalFiles.TabStop = false;
            this.gbLocalFiles.Text = "Local Files";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(17, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "* You can change the local video settings in the video link form";
            // 
            // lVideoSourceOK
            // 
            this.lVideoSourceOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lVideoSourceOK.AutoSize = true;
            this.lVideoSourceOK.Font = new System.Drawing.Font("Wingdings 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lVideoSourceOK.Location = new System.Drawing.Point(533, 110);
            this.lVideoSourceOK.Name = "lVideoSourceOK";
            this.lVideoSourceOK.Size = new System.Drawing.Size(22, 17);
            this.lVideoSourceOK.TabIndex = 17;
            this.lVideoSourceOK.Text = "W";
            // 
            // lOpenedLogOK
            // 
            this.lOpenedLogOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lOpenedLogOK.AutoSize = true;
            this.lOpenedLogOK.Font = new System.Drawing.Font("Wingdings 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lOpenedLogOK.Location = new System.Drawing.Point(533, 71);
            this.lOpenedLogOK.Name = "lOpenedLogOK";
            this.lOpenedLogOK.Size = new System.Drawing.Size(22, 17);
            this.lOpenedLogOK.TabIndex = 16;
            this.lOpenedLogOK.Text = "W";
            // 
            // lProjectFolderOK
            // 
            this.lProjectFolderOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lProjectFolderOK.AutoSize = true;
            this.lProjectFolderOK.Font = new System.Drawing.Font("Wingdings 2", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lProjectFolderOK.Location = new System.Drawing.Point(533, 32);
            this.lProjectFolderOK.Name = "lProjectFolderOK";
            this.lProjectFolderOK.Size = new System.Drawing.Size(22, 17);
            this.lProjectFolderOK.TabIndex = 15;
            this.lProjectFolderOK.Text = "W";
            // 
            // btnExtractZip
            // 
            this.btnExtractZip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtractZip.ImageIndex = 5;
            this.btnExtractZip.ImageList = this.IL;
            this.btnExtractZip.Location = new System.Drawing.Point(9, 48);
            this.btnExtractZip.Name = "btnExtractZip";
            this.btnExtractZip.Size = new System.Drawing.Size(122, 23);
            this.btnExtractZip.TabIndex = 19;
            this.btnExtractZip.Text = "Extract Archive";
            this.btnExtractZip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExtractZip.UseVisualStyleBackColor = true;
            this.btnExtractZip.Click += new System.EventHandler(this.BtnExtractZip_Click);
            // 
            // btnMake7zip
            // 
            this.btnMake7zip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMake7zip.ImageIndex = 0;
            this.btnMake7zip.ImageList = this.IL;
            this.btnMake7zip.Location = new System.Drawing.Point(9, 19);
            this.btnMake7zip.Name = "btnMake7zip";
            this.btnMake7zip.Size = new System.Drawing.Size(122, 23);
            this.btnMake7zip.TabIndex = 18;
            this.btnMake7zip.Text = "Create Archive";
            this.btnMake7zip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMake7zip.UseVisualStyleBackColor = true;
            this.btnMake7zip.Click += new System.EventHandler(this.BtnMake7zip_Click);
            // 
            // gbOnlineFile
            // 
            this.gbOnlineFile.Controls.Add(this.label4);
            this.gbOnlineFile.Controls.Add(this.label5);
            this.gbOnlineFile.Controls.Add(this.tYoutubeURL);
            this.gbOnlineFile.Controls.Add(this.btnDownloadSource);
            this.gbOnlineFile.Controls.Add(this.btnDownloadYoutube);
            this.gbOnlineFile.Controls.Add(this.tPackedLogsURL);
            this.gbOnlineFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOnlineFile.Location = new System.Drawing.Point(3, 3);
            this.gbOnlineFile.Name = "gbOnlineFile";
            this.gbOnlineFile.Size = new System.Drawing.Size(564, 162);
            this.gbOnlineFile.TabIndex = 16;
            this.gbOnlineFile.TabStop = false;
            this.gbOnlineFile.Text = "Online Files";
            // 
            // gbProjectInfo
            // 
            this.gbProjectInfo.BackColor = System.Drawing.SystemColors.Control;
            this.gbProjectInfo.Controls.Add(this.tTagBox);
            this.gbProjectInfo.Controls.Add(this.btnAddTag);
            this.gbProjectInfo.Controls.Add(this.tagContainer);
            this.gbProjectInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProjectInfo.Location = new System.Drawing.Point(3, 171);
            this.gbProjectInfo.Name = "gbProjectInfo";
            this.gbProjectInfo.Size = new System.Drawing.Size(564, 163);
            this.gbProjectInfo.TabIndex = 17;
            this.gbProjectInfo.TabStop = false;
            this.gbProjectInfo.Text = "Project Info";
            // 
            // tTagBox
            // 
            this.tTagBox.AutoCompleteCustomSource.AddRange(new string[] {
            "San d\'Oria",
            "Bastok",
            "Windurst",
            "Jeuno",
            "Mhaura",
            "Selbina"});
            this.tTagBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tTagBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tTagBox.Location = new System.Drawing.Point(20, 19);
            this.tTagBox.Name = "tTagBox";
            this.tTagBox.Size = new System.Drawing.Size(127, 20);
            this.tTagBox.TabIndex = 0;
            this.tTagBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TTagBox_KeyDown);
            // 
            // btnAddTag
            // 
            this.btnAddTag.ImageIndex = 6;
            this.btnAddTag.ImageList = this.IL;
            this.btnAddTag.Location = new System.Drawing.Point(153, 17);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(87, 23);
            this.btnAddTag.TabIndex = 1;
            this.btnAddTag.Text = "Add Tag";
            this.btnAddTag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.BtnAddTag_Click);
            // 
            // tagContainer
            // 
            this.tagContainer.AutoSize = true;
            this.tagContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tagContainer.Controls.Add(this.lTagLabel);
            this.tagContainer.Location = new System.Drawing.Point(9, 45);
            this.tagContainer.Name = "tagContainer";
            this.tagContainer.Size = new System.Drawing.Size(40, 13);
            this.tagContainer.TabIndex = 2;
            // 
            // lTagLabel
            // 
            this.lTagLabel.AutoSize = true;
            this.lTagLabel.Location = new System.Drawing.Point(3, 0);
            this.lTagLabel.Name = "lTagLabel";
            this.lTagLabel.Size = new System.Drawing.Size(34, 13);
            this.lTagLabel.TabIndex = 0;
            this.lTagLabel.Text = "Tags:";
            this.lTagLabel.Click += new System.EventHandler(this.LTagLabel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageIndex = 4;
            this.btnSave.ImageList = this.IL;
            this.btnSave.Location = new System.Drawing.Point(12, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCopySummary
            // 
            this.btnCopySummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopySummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopySummary.ImageIndex = 3;
            this.btnCopySummary.ImageList = this.IL;
            this.btnCopySummary.Location = new System.Drawing.Point(443, 376);
            this.btnCopySummary.Name = "btnCopySummary";
            this.btnCopySummary.Size = new System.Drawing.Size(122, 23);
            this.btnCopySummary.TabIndex = 18;
            this.btnCopySummary.Text = "Copy Summary";
            this.btnCopySummary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCopySummary.UseVisualStyleBackColor = true;
            this.btnCopySummary.Click += new System.EventHandler(this.BtnCopySummary_Click);
            // 
            // tcProjectInfo
            // 
            this.tcProjectInfo.Controls.Add(this.tpMainInfo);
            this.tcProjectInfo.Controls.Add(this.tabPage2);
            this.tcProjectInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcProjectInfo.Location = new System.Drawing.Point(0, 0);
            this.tcProjectInfo.Name = "tcProjectInfo";
            this.tcProjectInfo.SelectedIndex = 0;
            this.tcProjectInfo.Size = new System.Drawing.Size(584, 369);
            this.tcProjectInfo.TabIndex = 19;
            // 
            // tpMainInfo
            // 
            this.tpMainInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tpMainInfo.Controls.Add(this.tlProjectInfo);
            this.tpMainInfo.Location = new System.Drawing.Point(4, 22);
            this.tpMainInfo.Name = "tpMainInfo";
            this.tpMainInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpMainInfo.Size = new System.Drawing.Size(576, 343);
            this.tpMainInfo.TabIndex = 0;
            this.tpMainInfo.Text = "Project Information";
            // 
            // tlProjectInfo
            // 
            this.tlProjectInfo.ColumnCount = 1;
            this.tlProjectInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlProjectInfo.Controls.Add(this.gbLocalFiles, 0, 0);
            this.tlProjectInfo.Controls.Add(this.gbProjectInfo, 0, 1);
            this.tlProjectInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlProjectInfo.Location = new System.Drawing.Point(3, 3);
            this.tlProjectInfo.Name = "tlProjectInfo";
            this.tlProjectInfo.RowCount = 2;
            this.tlProjectInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlProjectInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlProjectInfo.Size = new System.Drawing.Size(570, 337);
            this.tlProjectInfo.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.tlCommunity);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(576, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Community Settings";
            // 
            // tlCommunity
            // 
            this.tlCommunity.ColumnCount = 1;
            this.tlCommunity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlCommunity.Controls.Add(this.groupBox1, 0, 1);
            this.tlCommunity.Controls.Add(this.gbOnlineFile, 0, 0);
            this.tlCommunity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlCommunity.Location = new System.Drawing.Point(3, 3);
            this.tlCommunity.Name = "tlCommunity";
            this.tlCommunity.RowCount = 2;
            this.tlCommunity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlCommunity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlCommunity.Size = new System.Drawing.Size(570, 337);
            this.tlCommunity.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUploadLogs);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lCurrentArchiveName);
            this.groupBox1.Controls.Add(this.btnMake7zip);
            this.groupBox1.Controls.Add(this.btnExtractZip);
            this.groupBox1.Controls.Add(this.btnUploadToYoutube);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 163);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(137, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 52);
            this.label6.TabIndex = 21;
            this.label6.Text = "}";
            // 
            // lCurrentArchiveName
            // 
            this.lCurrentArchiveName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lCurrentArchiveName.Location = new System.Drawing.Point(175, 19);
            this.lCurrentArchiveName.Name = "lCurrentArchiveName";
            this.lCurrentArchiveName.Size = new System.Drawing.Size(380, 52);
            this.lCurrentArchiveName.TabIndex = 20;
            this.lCurrentArchiveName.Text = "???";
            this.lCurrentArchiveName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lCurrentArchiveName.Click += new System.EventHandler(this.LCurrentArchiveName_Click);
            // 
            // btnUploadLogs
            // 
            this.btnUploadLogs.Enabled = false;
            this.btnUploadLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUploadLogs.ImageIndex = 1;
            this.btnUploadLogs.ImageList = this.IL;
            this.btnUploadLogs.Location = new System.Drawing.Point(9, 106);
            this.btnUploadLogs.Name = "btnUploadLogs";
            this.btnUploadLogs.Size = new System.Drawing.Size(160, 23);
            this.btnUploadLogs.TabIndex = 22;
            this.btnUploadLogs.Text = "Upload Logs";
            this.btnUploadLogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUploadLogs.UseVisualStyleBackColor = true;
            // 
            // ProjectInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.tcProjectInfo);
            this.Controls.Add(this.btnCopySummary);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProjectInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Project Information";
            this.Activated += new System.EventHandler(this.ProjectInfoForm_Activated);
            this.Load += new System.EventHandler(this.ProjectInfoForm_Load);
            this.Shown += new System.EventHandler(this.ProjectInfoForm_Shown);
            this.Enter += new System.EventHandler(this.ProjectInfoForm_Enter);
            this.gbLocalFiles.ResumeLayout(false);
            this.gbLocalFiles.PerformLayout();
            this.gbOnlineFile.ResumeLayout(false);
            this.gbOnlineFile.PerformLayout();
            this.gbProjectInfo.ResumeLayout(false);
            this.gbProjectInfo.PerformLayout();
            this.tagContainer.ResumeLayout(false);
            this.tagContainer.PerformLayout();
            this.tcProjectInfo.ResumeLayout(false);
            this.tpMainInfo.ResumeLayout(false);
            this.tlProjectInfo.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tlCommunity.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tProjectFolder;
        private System.Windows.Forms.TextBox tOpenedLog;
        private System.Windows.Forms.TextBox tSourceVideo;
        private System.Windows.Forms.TextBox tYoutubeURL;
        private System.Windows.Forms.TextBox tPackedLogsURL;
        private System.Windows.Forms.SaveFileDialog saveProjectDlg;
        private System.Windows.Forms.Button btnDownloadSource;
        private System.Windows.Forms.Button btnDownloadYoutube;
        private System.Windows.Forms.Button btnUploadToYoutube;
        private System.Windows.Forms.GroupBox gbLocalFiles;
        private System.Windows.Forms.GroupBox gbOnlineFile;
        private System.Windows.Forms.GroupBox gbProjectInfo;
        private System.Windows.Forms.TextBox tTagBox;
        private System.Windows.Forms.FlowLayoutPanel tagContainer;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.Label lTagLabel;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lVideoSourceOK;
        private System.Windows.Forms.Label lOpenedLogOK;
        private System.Windows.Forms.Label lProjectFolderOK;
        public System.Windows.Forms.Button btnCopySummary;
        private System.Windows.Forms.Button btnMake7zip;
        private System.Windows.Forms.ImageList IL;
        private System.Windows.Forms.Button btnExtractZip;
        private System.Windows.Forms.TabControl tcProjectInfo;
        private System.Windows.Forms.TabPage tpMainInfo;
        private System.Windows.Forms.TableLayoutPanel tlProjectInfo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tlCommunity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lCurrentArchiveName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUploadLogs;
    }
}