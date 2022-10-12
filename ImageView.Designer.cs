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
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.skinTabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.skinTabPage3 = new CCWin.SkinControl.SkinTabPage();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.btnTestLoadEnv = new System.Windows.Forms.Button();
            this.cmbListStepProg = new CCWin.SkinControl.SkinComboBox();
            this.chkRunEzRProg = new CCWin.SkinControl.SkinCheckBox();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.chkFilter = new CCWin.SkinControl.SkinCheckBox();
            this.chkFitPlane = new CCWin.SkinControl.SkinCheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsptxtYResolution = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tspcmbImageComp = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.skinTabControl1.SuspendLayout();
            this.skinTabPage1.SuspendLayout();
            this.skinTabPage2.SuspendLayout();
            this.skinTabPage3.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.skinGroupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            // skinTabControl1
            // 
            this.skinTabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.skinTabPage1);
            this.skinTabControl1.Controls.Add(this.skinTabPage3);
            this.skinTabControl1.Controls.Add(this.skinTabPage2);
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
            this.skinTabControl1.SelectedIndex = 0;
            this.skinTabControl1.Size = new System.Drawing.Size(809, 630);
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
            this.skinTabPage1.Size = new System.Drawing.Size(773, 630);
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
            this.elementHost1.Size = new System.Drawing.Size(773, 630);
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
            this.skinTabPage2.Size = new System.Drawing.Size(773, 630);
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
            this.elementHost2.Size = new System.Drawing.Size(773, 630);
            this.elementHost2.TabIndex = 2;
            this.elementHost2.Child = null;
            // 
            // skinTabPage3
            // 
            this.skinTabPage3.BackColor = System.Drawing.Color.White;
            this.skinTabPage3.Controls.Add(this.skinGroupBox2);
            this.skinTabPage3.Controls.Add(this.skinGroupBox1);
            this.skinTabPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage3.Location = new System.Drawing.Point(0, 0);
            this.skinTabPage3.Name = "skinTabPage3";
            this.skinTabPage3.Size = new System.Drawing.Size(773, 630);
            this.skinTabPage3.TabIndex = 2;
            this.skinTabPage3.TabItemImage = null;
            this.skinTabPage3.Text = "Core";
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.skinGroupBox2.Controls.Add(this.btnTestLoadEnv);
            this.skinGroupBox2.Controls.Add(this.cmbListStepProg);
            this.skinGroupBox2.Controls.Add(this.chkRunEzRProg);
            this.skinGroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinGroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.skinGroupBox2.Location = new System.Drawing.Point(0, 86);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(773, 86);
            this.skinGroupBox2.TabIndex = 3;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "     程序模块    ";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // btnTestLoadEnv
            // 
            this.btnTestLoadEnv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnTestLoadEnv.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTestLoadEnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestLoadEnv.Location = new System.Drawing.Point(289, 39);
            this.btnTestLoadEnv.Name = "btnTestLoadEnv";
            this.btnTestLoadEnv.Size = new System.Drawing.Size(92, 24);
            this.btnTestLoadEnv.TabIndex = 2;
            this.btnTestLoadEnv.Text = "加载Env";
            this.btnTestLoadEnv.UseVisualStyleBackColor = false;
            this.btnTestLoadEnv.Click += new System.EventHandler(this.btnTestLoadEnv_Click);
            // 
            // cmbListStepProg
            // 
            this.cmbListStepProg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbListStepProg.Enabled = false;
            this.cmbListStepProg.FormattingEnabled = true;
            this.cmbListStepProg.Location = new System.Drawing.Point(111, 39);
            this.cmbListStepProg.Name = "cmbListStepProg";
            this.cmbListStepProg.Size = new System.Drawing.Size(146, 24);
            this.cmbListStepProg.TabIndex = 1;
            this.cmbListStepProg.WaterText = "";
            // 
            // chkRunEzRProg
            // 
            this.chkRunEzRProg.AutoSize = true;
            this.chkRunEzRProg.BackColor = System.Drawing.Color.Transparent;
            this.chkRunEzRProg.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.chkRunEzRProg.DownBack = null;
            this.chkRunEzRProg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkRunEzRProg.Location = new System.Drawing.Point(24, 39);
            this.chkRunEzRProg.MouseBack = null;
            this.chkRunEzRProg.Name = "chkRunEzRProg";
            this.chkRunEzRProg.NormlBack = null;
            this.chkRunEzRProg.SelectedDownBack = null;
            this.chkRunEzRProg.SelectedMouseBack = null;
            this.chkRunEzRProg.SelectedNormlBack = null;
            this.chkRunEzRProg.Size = new System.Drawing.Size(75, 21);
            this.chkRunEzRProg.TabIndex = 0;
            this.chkRunEzRProg.Text = "执行程序";
            this.chkRunEzRProg.UseVisualStyleBackColor = false;
            this.chkRunEzRProg.CheckedChanged += new System.EventHandler(this.chkRunEzRProg_CheckedChanged);
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.skinGroupBox1.Controls.Add(this.chkFilter);
            this.skinGroupBox1.Controls.Add(this.chkFitPlane);
            this.skinGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinGroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.skinGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(773, 86);
            this.skinGroupBox1.TabIndex = 2;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "     常用功能   ";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // chkFilter
            // 
            this.chkFilter.AutoSize = true;
            this.chkFilter.BackColor = System.Drawing.Color.Transparent;
            this.chkFilter.ControlState = CCWin.SkinClass.ControlState.Focused;
            this.chkFilter.DownBack = null;
            this.chkFilter.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkFilter.Location = new System.Drawing.Point(24, 39);
            this.chkFilter.MouseBack = null;
            this.chkFilter.Name = "chkFilter";
            this.chkFilter.NormlBack = null;
            this.chkFilter.SelectedDownBack = null;
            this.chkFilter.SelectedMouseBack = null;
            this.chkFilter.SelectedNormlBack = null;
            this.chkFilter.Size = new System.Drawing.Size(51, 21);
            this.chkFilter.TabIndex = 0;
            this.chkFilter.Text = "滤波";
            this.chkFilter.UseVisualStyleBackColor = false;
            // 
            // chkFitPlane
            // 
            this.chkFitPlane.AutoSize = true;
            this.chkFitPlane.BackColor = System.Drawing.Color.Transparent;
            this.chkFitPlane.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chkFitPlane.DownBack = null;
            this.chkFitPlane.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkFitPlane.Location = new System.Drawing.Point(111, 39);
            this.chkFitPlane.MouseBack = null;
            this.chkFitPlane.Name = "chkFitPlane";
            this.chkFitPlane.NormlBack = null;
            this.chkFitPlane.SelectedDownBack = null;
            this.chkFitPlane.SelectedMouseBack = null;
            this.chkFitPlane.SelectedNormlBack = null;
            this.chkFitPlane.Size = new System.Drawing.Size(75, 21);
            this.chkFitPlane.TabIndex = 1;
            this.chkFitPlane.Text = "拟合平面";
            this.chkFitPlane.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tsptxtYResolution,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.tspcmbImageComp,
            this.toolStripSeparator2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 630);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(809, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(51, 22);
            this.toolStripLabel1.Text = "Y分辨率";
            // 
            // tsptxtYResolution
            // 
            this.tsptxtYResolution.Name = "tsptxtYResolution";
            this.tsptxtYResolution.Size = new System.Drawing.Size(69, 25);
            this.tsptxtYResolution.Text = "0.01";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel2.Text = "图像层";
            // 
            // tspcmbImageComp
            // 
            this.tspcmbImageComp.Items.AddRange(new object[] {
            "Intensity",
            "Range",
            "Scatter"});
            this.tspcmbImageComp.Name = "tspcmbImageComp";
            this.tspcmbImageComp.Size = new System.Drawing.Size(93, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(72, 22);
            this.toolStripLabel3.Text = "Image Info";
            // 
            // ImageView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
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
            this.skinTabControl1.ResumeLayout(false);
            this.skinTabPage1.ResumeLayout(false);
            this.skinTabPage2.ResumeLayout(false);
            this.skinTabPage3.ResumeLayout(false);
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private CCWin.SkinControl.SkinCheckBox chkFitPlane;
        private CCWin.SkinControl.SkinCheckBox chkFilter;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CCWin.SkinControl.SkinComboBox cmbListStepProg;
        private CCWin.SkinControl.SkinCheckBox chkRunEzRProg;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private System.Windows.Forms.Button btnTestLoadEnv;
    }
}