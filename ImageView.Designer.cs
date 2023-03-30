namespace ViewerProject
{
    partial class ImageView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageView));
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.folderTree1 = new NEV.ControlLib.CommonControl.FolderTree();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsptxtYResolution = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tspcmbImageComp = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsptxtImgInfo = new System.Windows.Forms.ToolStripTextBox();
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.skinTabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.skinTabPage3 = new CCWin.SkinControl.SkinTabPage();
            this.skinCaptionPanel1 = new CCWin.SkinControl.SkinCaptionPanel();
            this.btnOpenEzR = new System.Windows.Forms.Button();
            this.btnTestLoadEnv = new System.Windows.Forms.Button();
            this.chkRunEzRProg = new CCWin.SkinControl.SkinCheckBox();
            this.cmbListStepProg = new CCWin.SkinControl.SkinComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.skinTabControl1.SuspendLayout();
            this.skinTabPage1.SuspendLayout();
            this.skinTabPage2.SuspendLayout();
            this.skinTabPage3.SuspendLayout();
            this.skinCaptionPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(4, 28);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.folderTree1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.skinTabControl1);
            this.splitContainer3.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer3.Size = new System.Drawing.Size(1157, 655);
            this.splitContainer3.SplitterDistance = 342;
            this.splitContainer3.SplitterWidth = 6;
            this.splitContainer3.TabIndex = 2;
            // 
            // folderTree1
            // 
            this.folderTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderTree1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.folderTree1.Location = new System.Drawing.Point(0, 0);
            this.folderTree1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.folderTree1.MyPath = "";
            this.folderTree1.Name = "folderTree1";
            this.folderTree1.Size = new System.Drawing.Size(342, 655);
            this.folderTree1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsptxtYResolution,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.tspcmbImageComp,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.tsptxtImgInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 624);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(809, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(104, 28);
            this.toolStripLabel1.Text = "Y Resolution:";
            // 
            // tsptxtYResolution
            // 
            this.tsptxtYResolution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsptxtYResolution.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.tsptxtYResolution.Name = "tsptxtYResolution";
            this.tsptxtYResolution.Size = new System.Drawing.Size(69, 31);
            this.tsptxtYResolution.Text = "0.01";
            this.tsptxtYResolution.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tsptxtYResolution_KeyPress);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(97, 28);
            this.toolStripLabel2.Text = "Image Layer";
            // 
            // tspcmbImageComp
            // 
            this.tspcmbImageComp.BackColor = System.Drawing.SystemColors.Control;
            this.tspcmbImageComp.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.tspcmbImageComp.Items.AddRange(new object[] {
            "Intensity",
            "Range",
            "Scatter"});
            this.tspcmbImageComp.Name = "tspcmbImageComp";
            this.tspcmbImageComp.Size = new System.Drawing.Size(93, 31);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(86, 28);
            this.toolStripLabel3.Text = "Image Info";
            // 
            // tsptxtImgInfo
            // 
            this.tsptxtImgInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 8F);
            this.tsptxtImgInfo.Name = "tsptxtImgInfo";
            this.tsptxtImgInfo.ReadOnly = true;
            this.tsptxtImgInfo.Size = new System.Drawing.Size(450, 24);
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.skinTabPage1);
            this.skinTabControl1.Controls.Add(this.skinTabPage2);
            this.skinTabControl1.Controls.Add(this.skinTabPage3);
            this.skinTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl1.Location = new System.Drawing.Point(0, 0);
            this.skinTabControl1.Multiline = true;
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.SelectedIndex = 2;
            this.skinTabControl1.Size = new System.Drawing.Size(809, 624);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 0;
            // 
            // skinTabPage1
            // 
            this.skinTabPage1.BackColor = System.Drawing.Color.White;
            this.skinTabPage1.Controls.Add(this.elementHost1);
            this.skinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage1.Location = new System.Drawing.Point(0, 0);
            this.skinTabPage1.Name = "skinTabPage1";
            this.skinTabPage1.Size = new System.Drawing.Size(773, 624);
            this.skinTabPage1.TabIndex = 0;
            this.skinTabPage1.TabItemImage = null;
            this.skinTabPage1.Text = "2D";
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(773, 627);
            this.elementHost1.TabIndex = 1;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // skinTabPage2
            // 
            this.skinTabPage2.BackColor = System.Drawing.Color.White;
            this.skinTabPage2.Controls.Add(this.elementHost2);
            this.skinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage2.Location = new System.Drawing.Point(0, 0);
            this.skinTabPage2.Name = "skinTabPage2";
            this.skinTabPage2.Size = new System.Drawing.Size(773, 624);
            this.skinTabPage2.TabIndex = 1;
            this.skinTabPage2.TabItemImage = null;
            this.skinTabPage2.Text = "3D";
            // 
            // elementHost2
            // 
            this.elementHost2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost2.Location = new System.Drawing.Point(0, 0);
            this.elementHost2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(773, 627);
            this.elementHost2.TabIndex = 2;
            this.elementHost2.Child = null;
            // 
            // skinTabPage3
            // 
            this.skinTabPage3.BackColor = System.Drawing.Color.White;
            this.skinTabPage3.Controls.Add(this.skinCaptionPanel1);
            this.skinTabPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage3.Location = new System.Drawing.Point(0, 0);
            this.skinTabPage3.Name = "skinTabPage3";
            this.skinTabPage3.Size = new System.Drawing.Size(773, 624);
            this.skinTabPage3.TabIndex = 2;
            this.skinTabPage3.TabItemImage = null;
            this.skinTabPage3.Text = "Plus";
            // 
            // skinCaptionPanel1
            // 
            this.skinCaptionPanel1.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.skinCaptionPanel1.Controls.Add(this.btnOpenEzR);
            this.skinCaptionPanel1.Controls.Add(this.btnTestLoadEnv);
            this.skinCaptionPanel1.Controls.Add(this.chkRunEzRProg);
            this.skinCaptionPanel1.Controls.Add(this.cmbListStepProg);
            this.skinCaptionPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinCaptionPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinCaptionPanel1.Name = "skinCaptionPanel1";
            this.skinCaptionPanel1.Size = new System.Drawing.Size(773, 246);
            this.skinCaptionPanel1.TabIndex = 3;
            this.skinCaptionPanel1.Text = "EzR Function Block";
            // 
            // btnOpenEzR
            // 
            this.btnOpenEzR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnOpenEzR.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOpenEzR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenEzR.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btnOpenEzR.Location = new System.Drawing.Point(450, 62);
            this.btnOpenEzR.Name = "btnOpenEzR";
            this.btnOpenEzR.Size = new System.Drawing.Size(141, 55);
            this.btnOpenEzR.TabIndex = 3;
            this.btnOpenEzR.Text = "Open EzR";
            this.btnOpenEzR.UseVisualStyleBackColor = false;
            this.btnOpenEzR.Click += new System.EventHandler(this.btnOpenEzR_Click);
            // 
            // btnTestLoadEnv
            // 
            this.btnTestLoadEnv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnTestLoadEnv.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTestLoadEnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestLoadEnv.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btnTestLoadEnv.Location = new System.Drawing.Point(46, 62);
            this.btnTestLoadEnv.Name = "btnTestLoadEnv";
            this.btnTestLoadEnv.Size = new System.Drawing.Size(141, 55);
            this.btnTestLoadEnv.TabIndex = 2;
            this.btnTestLoadEnv.Text = "Load Env";
            this.btnTestLoadEnv.UseVisualStyleBackColor = false;
            this.btnTestLoadEnv.Click += new System.EventHandler(this.btnTestLoadEnv_Click);
            // 
            // chkRunEzRProg
            // 
            this.chkRunEzRProg.BackColor = System.Drawing.Color.Transparent;
            this.chkRunEzRProg.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.chkRunEzRProg.DownBack = null;
            this.chkRunEzRProg.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.chkRunEzRProg.LightEffect = false;
            this.chkRunEzRProg.Location = new System.Drawing.Point(46, 123);
            this.chkRunEzRProg.MouseBack = null;
            this.chkRunEzRProg.Name = "chkRunEzRProg";
            this.chkRunEzRProg.NormlBack = null;
            this.chkRunEzRProg.SelectedDownBack = null;
            this.chkRunEzRProg.SelectedMouseBack = null;
            this.chkRunEzRProg.SelectedNormlBack = null;
            this.chkRunEzRProg.Size = new System.Drawing.Size(166, 47);
            this.chkRunEzRProg.TabIndex = 0;
            this.chkRunEzRProg.Text = "RunEnable";
            this.chkRunEzRProg.UseVisualStyleBackColor = false;
            this.chkRunEzRProg.CheckedChanged += new System.EventHandler(this.chkRunEzRProg_CheckedChanged);
            // 
            // cmbListStepProg
            // 
            this.cmbListStepProg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbListStepProg.Enabled = false;
            this.cmbListStepProg.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
            this.cmbListStepProg.FormattingEnabled = true;
            this.cmbListStepProg.Location = new System.Drawing.Point(215, 78);
            this.cmbListStepProg.Name = "cmbListStepProg";
            this.cmbListStepProg.Size = new System.Drawing.Size(202, 39);
            this.cmbListStepProg.TabIndex = 1;
            this.cmbListStepProg.WaterText = "";
            // 
            // ImageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1165, 687);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer3);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MdiBackColor = System.Drawing.Color.Transparent;
            this.Mobile = CCWin.MobileStyle.None;
            this.MobileApi = false;
            this.Name = "ImageView";
            this.Shadow = false;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ImageView_Load);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.skinTabControl1.ResumeLayout(false);
            this.skinTabPage1.ResumeLayout(false);
            this.skinTabPage2.ResumeLayout(false);
            this.skinTabPage3.ResumeLayout(false);
            this.skinCaptionPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer3;
        private NEV.ControlLib.CommonControl.FolderTree folderTree1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tsptxtYResolution;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox tspcmbImageComp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTabPage skinTabPage1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private CCWin.SkinControl.SkinTabPage skinTabPage2;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private CCWin.SkinControl.SkinTabPage skinTabPage3;
        private CCWin.SkinControl.SkinComboBox cmbListStepProg;
        private CCWin.SkinControl.SkinCheckBox chkRunEzRProg;
        private System.Windows.Forms.Button btnTestLoadEnv;
        private System.Windows.Forms.ToolStripTextBox tsptxtImgInfo;
        private CCWin.SkinControl.SkinCaptionPanel skinCaptionPanel1;
        private System.Windows.Forms.Button btnOpenEzR;
    }
}