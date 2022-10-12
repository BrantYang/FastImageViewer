
using CCWin;
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
            tspcmbImageComp.SelectedIndex = 0;
            _env = new ProcessingEnvironment();
            _env.Load("EzRProg.env");
            viewer2D.Environment = _env;
            viewer3D.Init(null, _env);
            elementHost1.Child = viewer2D;
            elementHost2.Child = viewer3D;
            folderTree1.TreeItemDClicked += new NEV.ControlLib.CommonControl.FolderTree.TreeDClickItemHandle(myTreeView_TreeItemDClicked);
            cmbListStepProg.DataSource = GetSubProgram();
        }

        public List<string> GetSubProgram()
        {
            List<string> ListProg = new List<string>();
            foreach (StepProgram stp in _env.Programs)
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
                    viewer3D.Draw("Image");
                }
            }
            else if(PathStr.Contains(".dat"))
            {
                _env.LoadImageFile(PathStr, "Image", (float)Convert.ToDouble(tsptxtYResolution.Text));
                if (chkRunEzRProg.Checked)
                {
                    RunVisionProcess(Path.GetDirectoryName(PathStr) + "\\" + Path.GetFileNameWithoutExtension(PathStr), cmbListStepProg.Text);
                }
                viewer2D.DrawImage("Image", (SubComponent)tspcmbImageComp.SelectedIndex);
                viewer3D.Draw("Image");
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
                        _env.SetString("SavePath", SavePath);
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
            //Test copy step program, but failed

           // StepProgram temp = new StepProgram();
           // temp = (StepProgram)_env.GetStepProgram(cmbListStepProg.Text);
           //ProcessingEnvironment tempenv = new ProcessingEnvironment();
           // StepProgram stp = (StepProgram)tempenv.CreateStepProgram("Test");
           // stp.Env = tempenv;
           // stp = temp;
           // tempenv.Save("test.env");
            //TestLoadEnv();
        }
    }
}
