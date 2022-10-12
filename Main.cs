using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewerProject
{
    public partial class Main : CCSkinMain
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ImageView imvDlgf = new ImageView();

            imvDlgf.TopLevel = false;
            imvDlgf.Parent = panel1;
            imvDlgf.AutoSize = true;
            imvDlgf.AllowDrop = true;
            imvDlgf.FormBorderStyle = FormBorderStyle.None;
            imvDlgf.Dock = System.Windows.Forms.DockStyle.Fill;             
            //panel1.Controls.Add(imvDlgf);
            imvDlgf.Show();

        }
    }
}
