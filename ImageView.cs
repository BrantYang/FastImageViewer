
using CCWin;
using NEV.BaseUtility;
using Sick.EasyRanger;
using Sick.EasyRanger.Base;
using Sick.EasyRanger.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewerProject
{
    public partial class ImageView : CCSkinMain
    {
        public ProcessingEnvironment Env { get { return _env; } set { _env = value; } }

        private ProcessingEnvironment _env;
        private View2DControl viewer2D;
        private View3DControl viewer3D;
        public ImageView()
        {
            InitializeComponent();
            viewer2D = new View2DControl();
            viewer3D = new View3DControl();
        }

        public List<string> GetVariableNames(DataType dataType)
        {
            List<string> ListNames = new List<string>();
            foreach (IVariable ezrVar in _env.Variables)
            {
                if (ezrVar.Type == dataType)
                {
                    ListNames.Add(ezrVar.Name);
                }
            }
            return ListNames;
        }

        private void ImageView_Load(object sender, EventArgs e)
        {
            GetAppCfgData();
            skinTabControl1.SelectedIndex = 0;
            tspcmbImageComp.SelectedIndex = 0;
            _env = new ProcessingEnvironment();
            if(File.Exists(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"EzRProg.env"))
            {
                _env.Load("EzRProg.env");
            }
            viewer2D.Environment = _env;
            viewer3D.Init(null, _env);
            elementHost1.Child = viewer2D;
            elementHost2.Child = viewer3D;
            viewer3D.Clear3D(null,null);
            folderTree1.TreeItemDClicked += new NEV.ControlLib.CommonControl.FolderTree.TreeDClickItemHandle(myTreeView_TreeItemDClicked);
            cmbListStepProg.DataSource = GetSubProgram(_env);
        }

        private void GetAppCfgData()
        {
            try
            {
                tsptxtYResolution.Text = AppConfig.valueItem("YResolution");
            }
            catch
            {
                throw;
            }

        }

        public List<string> GetSubProgram(ProcessingEnvironment Env)
        {
            List<string> ListProg = new List<string>();
            foreach (StepProgram stp in Env.Programs)
            {
                ListProg.Add(stp.Name);
            }
            return ListProg;
        }

        private void myTreeView_TreeItemDClicked(string PathStr)
        {
            if(PathStr.Contains(".envar"))
            {
                if (_env.VariableExists("Image"))
                {
                    _env.RemoveVariable("Image");
                }
                _env.LoadVariables(PathStr);

                List<string> ListStr = GetVariableNames(DataType.Image);
                if (ListStr.Count>0)
                {
                    _env.RenameVariable(ListStr[0], "Image");
                    if(chkRunEzRProg.Checked)
                    {
                        RunVisionProcess(Path.GetDirectoryName(PathStr) + "\\" + Path.GetFileNameWithoutExtension(PathStr), cmbListStepProg.Text);
                    }
                    viewer2D.DrawImage("Image", (SubComponent)tspcmbImageComp.SelectedIndex);
                    viewer3D.Clear3D(null, null);
                    viewer3D.Draw("Image");
                    tsptxtImgInfo.Text = GetImageInfo("Image");
                }
            }
            else if(PathStr.Contains(".dat"))
            {
                _env.LoadImageFile(PathStr, "Image", GetYResolution(tsptxtYResolution.Text));
                if (chkRunEzRProg.Checked)
                {
                    RunVisionProcess(Path.GetDirectoryName(PathStr) + "\\" + Path.GetFileNameWithoutExtension(PathStr), cmbListStepProg.Text);
                }
                viewer2D.DrawImage("Image", (SubComponent)tspcmbImageComp.SelectedIndex);
                viewer3D.Clear3D(null, null);
                viewer3D.Draw("Image");
                tsptxtImgInfo.Text = GetImageInfo("Image");
            }
        }
        public float GetYResolution(string txtString)
        {
            if(Regex.IsMatch(txtString, @"^\d+(\.\d+)?$"))
            {
                return (float)Convert.ToDouble(txtString);
            }
            else
            {
                return (float)1.0;
            }
        }

        private string GetImageInfo(string ImageName)
        {
            if(_env.VariableExists(ImageName))
            {
               ImageBankInfo imgInfo =  _env.GetImageProperties(ImageName);
               StringBuilder strb = new StringBuilder();
               strb.Append("W:"+ imgInfo.Width.ToString());
               strb.Append(" H:" + imgInfo.Height.ToString());
               strb.Append(" XRes:" + imgInfo.XResolution.ToString("f3"));
               strb.Append(" YRes:" + imgInfo.YResolution.ToString("f3"));
               strb.Append(" ZMax:" + imgInfo.RangeMax.ToString("f2"));
               strb.Append(" ZMin:" + imgInfo.RangeMin.ToString("f2"));
               return strb.ToString();

            }
            else
            {
                return "";
            }


        }

        public void RunVisionProcess(string SavePath, string StepPrgName) 
        {
            try
            {
                if(_env.StepProgramExists(StepPrgName))
                {
                    Task task = Task.Run(() =>
                    {
                        Console.WriteLine("Task started");
                        //_env.SetString("SavePath", SavePath);
                        _env.GetStepProgram(StepPrgName).RunFromBeginning();
                        Console.WriteLine("Task started");
                    });
                    task.Wait();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void TestLoadEnv()
        {

            try
            {
                if (_env!=null)
                {
                    Task task = Task.Run(() =>
                    {
                        for(int i= 0; i<50;i++)
                        {
                            _env.Load("EzRProg.env");
                            System.Threading.Thread.Sleep(1000);
                        }

                    });
                    //task.Wait();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void chkRunEzRProg_CheckedChanged(object sender, EventArgs e)
        {
            if(chkRunEzRProg.Checked)
            {
                cmbListStepProg.Enabled = true;
            }
            else
            {
                cmbListStepProg.Enabled = false;
            }
        }

        private void btnTestLoadEnv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "EzR File(*.env)|*.env|All Files(*.*)|*.*";
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                _env.Load(openFileDialog.FileName);
                cmbListStepProg.DataSource = GetSubProgram(_env);
                _env.Save("EzRProg.env");
            }
        }

        private void tsptxtYResolution_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13)
                return;
            else
            {
                try
                {
                    AppConfig.modifyItem("YResolution", tsptxtYResolution.Text);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btnOpenEzR_Click(object sender, EventArgs e)
        {
            int hWnd = AssemblyInfoManage.FindWindow(null, @"EASYRANGER PROGRAM EDITOR - EZRPROG - SICK");
            if (hWnd == 0)
            {
                StartEzREditor(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase+ @"EzRProg.env");
            }
            else
            {
                MessageBox.Show("EasyRanger already be opened！");
            }
        }
        public void StartEzREditor(string path)
        {
            //define exe info class
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            //Set external exe's
            Info.FileName = @"C:\Program Files\SICK\EasyRanger Program Editor\ProgramEditor.exe";

            //Set external exe's startup path
            Info.Arguments = "\"" + path + "\"";
            Info.WorkingDirectory = @"C:\Program Files\SICK\EasyRanger Program Editor\";

            System.Diagnostics.Process Proc;
            try
            {
                Proc = System.Diagnostics.Process.Start(Info);
            }
            catch (Exception ee)
            {
                //return;
            }
        }
    }
}
