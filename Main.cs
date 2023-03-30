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
            this.Text = String.Format("{0}", AssemblyInfoManage.AssemblyTitle);
            this.labelProductName.Text = AssemblyInfoManage.AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyInfoManage.AssemblyVersion);
            this.labelCopyright.Text = AssemblyInfoManage.AssemblyCopyright; 
            this.labelCompanyName.Text = String.Format("Company: {0}", AssemblyInfoManage.AssemblyCompany);
            this.textBoxDescription.Text = AssemblyInfoManage.AssemblyDescription;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                skinTabControl1.SelectedIndex = 0;
                ImageView imvDlgf = new ImageView();
                imvDlgf.TopLevel = false;
                imvDlgf.Parent = tpg3DView;
                imvDlgf.AutoSize = true;
                imvDlgf.AllowDrop = true;
                imvDlgf.FormBorderStyle = FormBorderStyle.None;
                imvDlgf.Dock = System.Windows.Forms.DockStyle.Fill;
                //panel1.Controls.Add(imvDlgf);
                imvDlgf.Show();

                EnvCopyFrm envCopyFrm = new EnvCopyFrm();
                envCopyFrm.TopLevel = false;
                envCopyFrm.Parent = tpgEnvTool;
                envCopyFrm.AutoSize = true;
                envCopyFrm.AllowDrop = true;
                envCopyFrm.FormBorderStyle = FormBorderStyle.None;
                envCopyFrm.Dock = System.Windows.Forms.DockStyle.Fill;
                //panel1.Controls.Add(imvDlgf);
                envCopyFrm.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
