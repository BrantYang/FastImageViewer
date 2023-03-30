
namespace ViewerProject
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.tpg3DView = new CCWin.SkinControl.SkinTabPage();
            this.tpgEnvTool = new CCWin.SkinControl.SkinTabPage();
            this.tpgAbout = new CCWin.SkinControl.SkinTabPage();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.skinCaptionPanel1 = new CCWin.SkinControl.SkinCaptionPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.skinTabControl1.SuspendLayout();
            this.tpgAbout.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.skinCaptionPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.skinTabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 539);
            this.panel1.TabIndex = 0;
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.tpg3DView);
            this.skinTabControl1.Controls.Add(this.tpgEnvTool);
            this.skinTabControl1.Controls.Add(this.tpgAbout);
            this.skinTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(150, 36);
            this.skinTabControl1.Location = new System.Drawing.Point(0, 0);
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
            this.skinTabControl1.Size = new System.Drawing.Size(967, 539);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 0;
            // 
            // tpg3DView
            // 
            this.tpg3DView.BackColor = System.Drawing.Color.White;
            this.tpg3DView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpg3DView.Location = new System.Drawing.Point(0, 0);
            this.tpg3DView.Name = "tpg3DView";
            this.tpg3DView.Size = new System.Drawing.Size(967, 503);
            this.tpg3DView.TabIndex = 0;
            this.tpg3DView.TabItemImage = null;
            this.tpg3DView.Text = "Image Viewer";
            // 
            // tpgEnvTool
            // 
            this.tpgEnvTool.BackColor = System.Drawing.Color.White;
            this.tpgEnvTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpgEnvTool.Location = new System.Drawing.Point(0, 0);
            this.tpgEnvTool.Name = "tpgEnvTool";
            this.tpgEnvTool.Size = new System.Drawing.Size(967, 503);
            this.tpgEnvTool.TabIndex = 1;
            this.tpgEnvTool.TabItemImage = null;
            this.tpgEnvTool.Text = "Env Tool";
            // 
            // tpgAbout
            // 
            this.tpgAbout.BackColor = System.Drawing.Color.White;
            this.tpgAbout.Controls.Add(this.tableLayoutPanel);
            this.tpgAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpgAbout.Location = new System.Drawing.Point(0, 0);
            this.tpgAbout.Name = "tpgAbout";
            this.tpgAbout.Size = new System.Drawing.Size(967, 503);
            this.tpgAbout.TabIndex = 2;
            this.tpgAbout.TabItemImage = null;
            this.tpgAbout.Text = "About";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.09146F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.90854F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.skinCaptionPanel1, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.9165F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.92445F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(967, 503);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(2, 2);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(383, 499);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBoxDescription.Location = new System.Drawing.Point(390, 223);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.tableLayoutPanel.SetRowSpan(this.textBoxDescription, 2);
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(574, 277);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Note:";
            // 
            // skinCaptionPanel1
            // 
            this.skinCaptionPanel1.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.skinCaptionPanel1.Controls.Add(this.label1);
            this.skinCaptionPanel1.Controls.Add(this.labelProductName);
            this.skinCaptionPanel1.Controls.Add(this.labelVersion);
            this.skinCaptionPanel1.Controls.Add(this.labelCopyright);
            this.skinCaptionPanel1.Controls.Add(this.labelCompanyName);
            this.skinCaptionPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinCaptionPanel1.Location = new System.Drawing.Point(390, 3);
            this.skinCaptionPanel1.Name = "skinCaptionPanel1";
            this.tableLayoutPanel.SetRowSpan(this.skinCaptionPanel1, 4);
            this.skinCaptionPanel1.Size = new System.Drawing.Size(574, 214);
            this.skinCaptionPanel1.TabIndex = 24;
            this.skinCaptionPanel1.Text = "Software Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(5, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Programmer :  Brant Yang@sick.com";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProductName.Location = new System.Drawing.Point(5, 35);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(145, 20);
            this.labelProductName.TabIndex = 24;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVersion.Location = new System.Drawing.Point(5, 70);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(81, 20);
            this.labelVersion.TabIndex = 23;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCopyright.Location = new System.Drawing.Point(5, 105);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(102, 20);
            this.labelCopyright.TabIndex = 25;
            this.labelCopyright.Text = "Copyright";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCompanyName.Location = new System.Drawing.Point(5, 175);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
            this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(100, 20);
            this.labelCompanyName.TabIndex = 26;
            this.labelCompanyName.Text = "Company";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(975, 571);
            this.Controls.Add(this.panel1);
            this.EffectBack = System.Drawing.Color.Transparent;
            this.EffectCaption = CCWin.TitleType.Title;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Image Viewer V1.0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.skinTabControl1.ResumeLayout(false);
            this.tpgAbout.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.skinCaptionPanel1.ResumeLayout(false);
            this.skinCaptionPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTabPage tpg3DView;
        private CCWin.SkinControl.SkinTabPage tpgEnvTool;
        private CCWin.SkinControl.SkinTabPage tpgAbout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TextBox textBoxDescription;
        private CCWin.SkinControl.SkinCaptionPanel skinCaptionPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
    }
}

