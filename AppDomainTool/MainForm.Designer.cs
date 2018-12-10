namespace AppDomainTool {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveARFFAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.showPlatformsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LeftSplitPanel = new System.Windows.Forms.Panel();
            this.PostList = new System.Windows.Forms.ListBox();
            this.RightSplitPanel = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.PostText = new System.Windows.Forms.RichTextBox();
            this.BottomSplitPanel = new System.Windows.Forms.Panel();
            this.bt_Prev = new System.Windows.Forms.Button();
            this.bt_Next = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ck_Bug = new System.Windows.Forms.CheckBox();
            this.ck_Technical = new System.Windows.Forms.CheckBox();
            this.ck_Feature = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ck_Business = new System.Windows.Forms.CheckBox();
            this.ck_Human = new System.Windows.Forms.CheckBox();
            this.ck_Market = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Rating = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Platform = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_App = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TopSplitPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.LeftSplitPanel.SuspendLayout();
            this.RightSplitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.BottomSplitPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveARFFAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.loadToolStripMenuItem.Text = "&Open ARFF...";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.saveToolStripMenuItem.Text = "&Save ARFF";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveARFFAsToolStripMenuItem
            // 
            this.saveARFFAsToolStripMenuItem.Name = "saveARFFAsToolStripMenuItem";
            this.saveARFFAsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.saveARFFAsToolStripMenuItem.Text = "Save ARFF &As...";
            this.saveARFFAsToolStripMenuItem.Click += new System.EventHandler(this.saveARFFAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextToolStripMenuItem,
            this.prevToolStripMenuItem,
            this.toolStripSeparator4,
            this.showPlatformsToolStripMenuItem,
            this.showAllToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.nextToolStripMenuItem.Text = "Next post";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // prevToolStripMenuItem
            // 
            this.prevToolStripMenuItem.Name = "prevToolStripMenuItem";
            this.prevToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.prevToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.prevToolStripMenuItem.Text = "Previous post";
            this.prevToolStripMenuItem.Click += new System.EventHandler(this.prevToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(183, 6);
            // 
            // showPlatformsToolStripMenuItem
            // 
            this.showPlatformsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.twitterToolStripMenuItem,
            this.appStoreToolStripMenuItem,
            this.playStoreToolStripMenuItem});
            this.showPlatformsToolStripMenuItem.Name = "showPlatformsToolStripMenuItem";
            this.showPlatformsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.showPlatformsToolStripMenuItem.Text = "Show platforms";
            // 
            // twitterToolStripMenuItem
            // 
            this.twitterToolStripMenuItem.Checked = true;
            this.twitterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.twitterToolStripMenuItem.Name = "twitterToolStripMenuItem";
            this.twitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.twitterToolStripMenuItem.Text = "Twitter";
            this.twitterToolStripMenuItem.Click += new System.EventHandler(this.twitterToolStripMenuItem_Click);
            // 
            // appStoreToolStripMenuItem
            // 
            this.appStoreToolStripMenuItem.Checked = true;
            this.appStoreToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.appStoreToolStripMenuItem.Name = "appStoreToolStripMenuItem";
            this.appStoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.appStoreToolStripMenuItem.Text = "Appstore";
            this.appStoreToolStripMenuItem.Click += new System.EventHandler(this.appStoreToolStripMenuItem_Click);
            // 
            // playStoreToolStripMenuItem
            // 
            this.playStoreToolStripMenuItem.Checked = true;
            this.playStoreToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.playStoreToolStripMenuItem.Name = "playStoreToolStripMenuItem";
            this.playStoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playStoreToolStripMenuItem.Text = "Playstore";
            this.playStoreToolStripMenuItem.Click += new System.EventHandler(this.playStoreToolStripMenuItem_Click);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.showAllToolStripMenuItem.Text = "Show all";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LeftSplitPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RightSplitPanel);
            this.splitContainer1.Size = new System.Drawing.Size(784, 537);
            this.splitContainer1.SplitterDistance = 351;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // LeftSplitPanel
            // 
            this.LeftSplitPanel.Controls.Add(this.PostList);
            this.LeftSplitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftSplitPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftSplitPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LeftSplitPanel.Name = "LeftSplitPanel";
            this.LeftSplitPanel.Size = new System.Drawing.Size(351, 537);
            this.LeftSplitPanel.TabIndex = 0;
            // 
            // PostList
            // 
            this.PostList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PostList.FormattingEnabled = true;
            this.PostList.Location = new System.Drawing.Point(0, 0);
            this.PostList.Name = "PostList";
            this.PostList.Size = new System.Drawing.Size(351, 537);
            this.PostList.TabIndex = 2;
            this.PostList.SelectedIndexChanged += new System.EventHandler(this.PostList_SelectedIndexChanged);
            // 
            // RightSplitPanel
            // 
            this.RightSplitPanel.Controls.Add(this.splitContainer2);
            this.RightSplitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightSplitPanel.Location = new System.Drawing.Point(0, 0);
            this.RightSplitPanel.Margin = new System.Windows.Forms.Padding(2);
            this.RightSplitPanel.Name = "RightSplitPanel";
            this.RightSplitPanel.Size = new System.Drawing.Size(430, 537);
            this.RightSplitPanel.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.PostText);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.BottomSplitPanel);
            this.splitContainer2.Size = new System.Drawing.Size(430, 537);
            this.splitContainer2.SplitterDistance = 378;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // PostText
            // 
            this.PostText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PostText.Location = new System.Drawing.Point(0, 0);
            this.PostText.Margin = new System.Windows.Forms.Padding(2);
            this.PostText.Name = "PostText";
            this.PostText.ReadOnly = true;
            this.PostText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PostText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.PostText.Size = new System.Drawing.Size(430, 378);
            this.PostText.TabIndex = 1;
            this.PostText.Text = "Open an ARFF file to view posts.";
            // 
            // BottomSplitPanel
            // 
            this.BottomSplitPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomSplitPanel.Controls.Add(this.bt_Prev);
            this.BottomSplitPanel.Controls.Add(this.bt_Next);
            this.BottomSplitPanel.Controls.Add(this.groupBox2);
            this.BottomSplitPanel.Controls.Add(this.groupBox1);
            this.BottomSplitPanel.Location = new System.Drawing.Point(-6, 1);
            this.BottomSplitPanel.Margin = new System.Windows.Forms.Padding(2);
            this.BottomSplitPanel.MaximumSize = new System.Drawing.Size(434, 160);
            this.BottomSplitPanel.MinimumSize = new System.Drawing.Size(434, 160);
            this.BottomSplitPanel.Name = "BottomSplitPanel";
            this.BottomSplitPanel.Size = new System.Drawing.Size(434, 160);
            this.BottomSplitPanel.TabIndex = 0;
            // 
            // bt_Prev
            // 
            this.bt_Prev.Location = new System.Drawing.Point(275, 128);
            this.bt_Prev.Name = "bt_Prev";
            this.bt_Prev.Size = new System.Drawing.Size(75, 23);
            this.bt_Prev.TabIndex = 3;
            this.bt_Prev.Text = "Previous";
            this.bt_Prev.UseVisualStyleBackColor = true;
            this.bt_Prev.Click += new System.EventHandler(this.bt_Prev_Click);
            // 
            // bt_Next
            // 
            this.bt_Next.Location = new System.Drawing.Point(356, 127);
            this.bt_Next.Name = "bt_Next";
            this.bt_Next.Size = new System.Drawing.Size(75, 23);
            this.bt_Next.TabIndex = 2;
            this.bt_Next.Text = "Next";
            this.bt_Next.UseVisualStyleBackColor = true;
            this.bt_Next.Click += new System.EventHandler(this.bt_Next_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(222, 158);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Post Categories";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.ck_Bug);
            this.groupBox4.Controls.Add(this.ck_Technical);
            this.groupBox4.Controls.Add(this.ck_Feature);
            this.groupBox4.Location = new System.Drawing.Point(96, 27);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(122, 124);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Technically Relevant";
            // 
            // ck_Bug
            // 
            this.ck_Bug.AutoSize = true;
            this.ck_Bug.Location = new System.Drawing.Point(13, 41);
            this.ck_Bug.Margin = new System.Windows.Forms.Padding(2);
            this.ck_Bug.Name = "ck_Bug";
            this.ck_Bug.Size = new System.Drawing.Size(80, 17);
            this.ck_Bug.TabIndex = 6;
            this.ck_Bug.Text = "Bug Report";
            this.ck_Bug.UseVisualStyleBackColor = true;
            this.ck_Bug.CheckedChanged += new System.EventHandler(this.ck_Bug_CheckedChanged);
            // 
            // ck_Technical
            // 
            this.ck_Technical.AutoSize = true;
            this.ck_Technical.Enabled = false;
            this.ck_Technical.Location = new System.Drawing.Point(13, 102);
            this.ck_Technical.Margin = new System.Windows.Forms.Padding(2);
            this.ck_Technical.Name = "ck_Technical";
            this.ck_Technical.Size = new System.Drawing.Size(73, 17);
            this.ck_Technical.TabIndex = 2;
            this.ck_Technical.Text = "Technical";
            this.ck_Technical.UseVisualStyleBackColor = true;
            // 
            // ck_Feature
            // 
            this.ck_Feature.AutoSize = true;
            this.ck_Feature.Location = new System.Drawing.Point(13, 62);
            this.ck_Feature.Margin = new System.Windows.Forms.Padding(2);
            this.ck_Feature.Name = "ck_Feature";
            this.ck_Feature.Size = new System.Drawing.Size(105, 17);
            this.ck_Feature.TabIndex = 5;
            this.ck_Feature.Text = "Feature Request";
            this.ck_Feature.UseVisualStyleBackColor = true;
            this.ck_Feature.CheckedChanged += new System.EventHandler(this.ck_Feature_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ck_Business);
            this.groupBox3.Controls.Add(this.ck_Human);
            this.groupBox3.Controls.Add(this.ck_Market);
            this.groupBox3.Location = new System.Drawing.Point(5, 27);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(86, 124);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Business Relevant";
            // 
            // ck_Business
            // 
            this.ck_Business.AutoSize = true;
            this.ck_Business.Enabled = false;
            this.ck_Business.Location = new System.Drawing.Point(5, 102);
            this.ck_Business.Margin = new System.Windows.Forms.Padding(2);
            this.ck_Business.Name = "ck_Business";
            this.ck_Business.Size = new System.Drawing.Size(68, 17);
            this.ck_Business.TabIndex = 1;
            this.ck_Business.Text = "Business";
            this.ck_Business.UseVisualStyleBackColor = true;
            // 
            // ck_Human
            // 
            this.ck_Human.AutoSize = true;
            this.ck_Human.Location = new System.Drawing.Point(5, 41);
            this.ck_Human.Margin = new System.Windows.Forms.Padding(2);
            this.ck_Human.Name = "ck_Human";
            this.ck_Human.Size = new System.Drawing.Size(60, 17);
            this.ck_Human.TabIndex = 4;
            this.ck_Human.Text = "Human";
            this.ck_Human.UseVisualStyleBackColor = true;
            this.ck_Human.CheckedChanged += new System.EventHandler(this.ck_Human_CheckedChanged);
            // 
            // ck_Market
            // 
            this.ck_Market.AutoSize = true;
            this.ck_Market.Location = new System.Drawing.Point(5, 62);
            this.ck_Market.Margin = new System.Windows.Forms.Padding(2);
            this.ck_Market.Name = "ck_Market";
            this.ck_Market.Size = new System.Drawing.Size(59, 17);
            this.ck_Market.TabIndex = 3;
            this.ck_Market.Text = "Market";
            this.ck_Market.UseVisualStyleBackColor = true;
            this.ck_Market.CheckedChanged += new System.EventHandler(this.ck_Market_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tb_Rating);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_Platform);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_App);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(227, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(205, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Post Properties";
            // 
            // tb_Rating
            // 
            this.tb_Rating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Rating.Location = new System.Drawing.Point(150, 66);
            this.tb_Rating.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Rating.Name = "tb_Rating";
            this.tb_Rating.ReadOnly = true;
            this.tb_Rating.Size = new System.Drawing.Size(50, 20);
            this.tb_Rating.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rating";
            // 
            // tb_Platform
            // 
            this.tb_Platform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Platform.Location = new System.Drawing.Point(70, 41);
            this.tb_Platform.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Platform.Name = "tb_Platform";
            this.tb_Platform.ReadOnly = true;
            this.tb_Platform.Size = new System.Drawing.Size(130, 20);
            this.tb_Platform.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Platform";
            // 
            // tb_App
            // 
            this.tb_App.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_App.Location = new System.Drawing.Point(70, 17);
            this.tb_App.Margin = new System.Windows.Forms.Padding(2);
            this.tb_App.Name = "tb_App";
            this.tb_App.ReadOnly = true;
            this.tb_App.Size = new System.Drawing.Size(130, 20);
            this.tb_App.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "App";
            // 
            // TopSplitPanel
            // 
            this.TopSplitPanel.Location = new System.Drawing.Point(215, 22);
            this.TopSplitPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TopSplitPanel.Name = "TopSplitPanel";
            this.TopSplitPanel.Size = new System.Drawing.Size(495, 134);
            this.TopSplitPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.TopSplitPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(643, 488);
            this.Name = "MainForm";
            this.Text = "App Domain Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.LeftSplitPanel.ResumeLayout(false);
            this.RightSplitPanel.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.BottomSplitPanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveARFFAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prevToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem showPlatformsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel LeftSplitPanel;
        private System.Windows.Forms.Panel RightSplitPanel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel TopSplitPanel;
        private System.Windows.Forms.Panel BottomSplitPanel;
        private System.Windows.Forms.RichTextBox PostText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_App;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Platform;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Rating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ck_Business;
        private System.Windows.Forms.CheckBox ck_Technical;
        private System.Windows.Forms.CheckBox ck_Market;
        private System.Windows.Forms.CheckBox ck_Human;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ck_Bug;
        private System.Windows.Forms.CheckBox ck_Feature;
        private System.Windows.Forms.Button bt_Next;
        private System.Windows.Forms.Button bt_Prev;
        private System.Windows.Forms.ListBox PostList;
    }
}

