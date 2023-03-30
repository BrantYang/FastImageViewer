
namespace ViewerProject
{
    partial class EnvCopyFrm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTarget2Source = new CCWin.SkinControl.SkinButton();
            this.lsbSourceProgList = new CCWin.SkinControl.SkinListBox();
            this.btnLoadSourceEnv = new CCWin.SkinControl.SkinButton();
            this.btnLoadTargetEnv = new CCWin.SkinControl.SkinButton();
            this.lsbTargetProgList = new CCWin.SkinControl.SkinListBox();
            this.btnSource2Target = new CCWin.SkinControl.SkinButton();
            this.btnSave = new CCWin.SkinControl.SkinButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.btnTarget2Source, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lsbSourceProgList, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadSourceEnv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLoadTargetEnv, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lsbTargetProgList, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSource2Target, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 28);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1156, 595);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnTarget2Source
            // 
            this.btnTarget2Source.BackColor = System.Drawing.Color.Transparent;
            this.btnTarget2Source.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnTarget2Source.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTarget2Source.DownBack = null;
            this.btnTarget2Source.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            this.btnTarget2Source.Location = new System.Drawing.Point(466, 331);
            this.btnTarget2Source.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTarget2Source.MouseBack = null;
            this.btnTarget2Source.Name = "btnTarget2Source";
            this.btnTarget2Source.NormlBack = null;
            this.btnTarget2Source.Size = new System.Drawing.Size(223, 87);
            this.btnTarget2Source.TabIndex = 10;
            this.btnTarget2Source.Text = "<<--";
            this.btnTarget2Source.UseVisualStyleBackColor = false;
            this.btnTarget2Source.Click += new System.EventHandler(this.btnTarget2Source_Click);
            // 
            // lsbSourceProgList
            // 
            this.lsbSourceProgList.Back = null;
            this.lsbSourceProgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbSourceProgList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lsbSourceProgList.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lsbSourceProgList.FormattingEnabled = true;
            this.lsbSourceProgList.ItemHeight = 30;
            this.lsbSourceProgList.Location = new System.Drawing.Point(4, 64);
            this.lsbSourceProgList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsbSourceProgList.MouseColor = System.Drawing.Color.LightCyan;
            this.lsbSourceProgList.Name = "lsbSourceProgList";
            this.lsbSourceProgList.RowBackColor2 = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetRowSpan(this.lsbSourceProgList, 2);
            this.lsbSourceProgList.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.lsbSourceProgList.Size = new System.Drawing.Size(454, 526);
            this.lsbSourceProgList.TabIndex = 7;
            this.lsbSourceProgList.DoubleClick += new System.EventHandler(this.lsbSourceProgList_DoubleClick);
            this.lsbSourceProgList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsbSourceProgList_KeyDown);
            // 
            // btnLoadSourceEnv
            // 
            this.btnLoadSourceEnv.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadSourceEnv.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLoadSourceEnv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadSourceEnv.DownBack = null;
            this.btnLoadSourceEnv.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadSourceEnv.Location = new System.Drawing.Point(4, 5);
            this.btnLoadSourceEnv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadSourceEnv.MouseBack = null;
            this.btnLoadSourceEnv.Name = "btnLoadSourceEnv";
            this.btnLoadSourceEnv.NormlBack = null;
            this.btnLoadSourceEnv.Size = new System.Drawing.Size(454, 49);
            this.btnLoadSourceEnv.TabIndex = 5;
            this.btnLoadSourceEnv.Text = "Load Source Env";
            this.btnLoadSourceEnv.UseVisualStyleBackColor = false;
            this.btnLoadSourceEnv.Click += new System.EventHandler(this.btnLoadSourceEnv_Click);
            // 
            // btnLoadTargetEnv
            // 
            this.btnLoadTargetEnv.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadTargetEnv.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLoadTargetEnv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoadTargetEnv.DownBack = null;
            this.btnLoadTargetEnv.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadTargetEnv.Location = new System.Drawing.Point(697, 5);
            this.btnLoadTargetEnv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadTargetEnv.MouseBack = null;
            this.btnLoadTargetEnv.Name = "btnLoadTargetEnv";
            this.btnLoadTargetEnv.NormlBack = null;
            this.btnLoadTargetEnv.Size = new System.Drawing.Size(455, 49);
            this.btnLoadTargetEnv.TabIndex = 6;
            this.btnLoadTargetEnv.Text = "Load Target Env";
            this.btnLoadTargetEnv.UseVisualStyleBackColor = false;
            this.btnLoadTargetEnv.Click += new System.EventHandler(this.btnLoadTargetEnv_Click);
            // 
            // lsbTargetProgList
            // 
            this.lsbTargetProgList.Back = null;
            this.lsbTargetProgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbTargetProgList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lsbTargetProgList.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lsbTargetProgList.FormattingEnabled = true;
            this.lsbTargetProgList.ItemHeight = 30;
            this.lsbTargetProgList.Location = new System.Drawing.Point(697, 64);
            this.lsbTargetProgList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsbTargetProgList.MouseColor = System.Drawing.Color.LightCyan;
            this.lsbTargetProgList.Name = "lsbTargetProgList";
            this.lsbTargetProgList.RowBackColor2 = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetRowSpan(this.lsbTargetProgList, 2);
            this.lsbTargetProgList.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.lsbTargetProgList.Size = new System.Drawing.Size(455, 526);
            this.lsbTargetProgList.TabIndex = 8;
            this.lsbTargetProgList.DoubleClick += new System.EventHandler(this.lsbTargetProgList_DoubleClick);
            this.lsbTargetProgList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsbTargetProgList_KeyDown);
            // 
            // btnSource2Target
            // 
            this.btnSource2Target.BackColor = System.Drawing.Color.Transparent;
            this.btnSource2Target.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSource2Target.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSource2Target.DownBack = null;
            this.btnSource2Target.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            this.btnSource2Target.Location = new System.Drawing.Point(466, 234);
            this.btnSource2Target.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSource2Target.MouseBack = null;
            this.btnSource2Target.Name = "btnSource2Target";
            this.btnSource2Target.NormlBack = null;
            this.btnSource2Target.Size = new System.Drawing.Size(223, 87);
            this.btnSource2Target.TabIndex = 9;
            this.btnSource2Target.Text = "-->>";
            this.btnSource2Target.UseVisualStyleBackColor = false;
            this.btnSource2Target.Click += new System.EventHandler(this.btnSource2Target_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.DownBack = null;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(466, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.MouseBack = null;
            this.btnSave.Name = "btnSave";
            this.btnSave.NormlBack = null;
            this.btnSave.Size = new System.Drawing.Size(223, 49);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EnvCopyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1164, 627);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.EffectBack = System.Drawing.Color.Transparent;
            this.EffectCaption = CCWin.TitleType.None;
            this.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnvCopyFrm";
            this.Shadow = false;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "EnvCopyFrm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CCWin.SkinControl.SkinButton btnLoadSourceEnv;
        private CCWin.SkinControl.SkinButton btnLoadTargetEnv;
        private CCWin.SkinControl.SkinListBox lsbSourceProgList;
        private CCWin.SkinControl.SkinListBox lsbTargetProgList;
        private CCWin.SkinControl.SkinButton btnSource2Target;
        private CCWin.SkinControl.SkinButton btnTarget2Source;
        private CCWin.SkinControl.SkinButton btnSave;
    }
}