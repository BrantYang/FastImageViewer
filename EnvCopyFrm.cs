using CCWin;
using CCWin.SkinControl;
using Sick.EasyRanger;
using Sick.EasyRanger.Base;
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
    public partial class EnvCopyFrm : CCSkinMain
    {
        EnvTransferTool envTransferTool = null;
        private ProcessingEnvironment sourceEnv = null;
        private ProcessingEnvironment targetEnv = null;

        string path_sourceEnv = "";
        string path_targetEnv = "";
        public EnvCopyFrm()
        {
            InitializeComponent();
            sourceEnv = new ProcessingEnvironment();
            targetEnv = new ProcessingEnvironment();
    }

        public List<string> GetSubProgram(ProcessingEnvironment env)
        {
            List<string> ListProg = new List<string>();
            foreach (StepProgram stp in env.Programs)
            {
                ListProg.Add(stp.Name);
            }
            return ListProg;
        }

        private void RefreshItems(SkinListBox lstBox, ProcessingEnvironment env)
        {
            lstBox.Items.Clear();
            List<string> ListNames = GetSubProgram(env);
            foreach(string temp in ListNames)
            {
                SkinListBoxItem listBoxItem = new SkinListBoxItem(temp);
                lstBox.Items.Add(listBoxItem);
            }
        }

        public List<string> GetVariableNames(DataType dataType, ProcessingEnvironment env)
        {
            List<string> ListImgName = new List<string>();
            //_activeVariables.Reset(_env.Variables);
            foreach (IVariable ezrVar in env.Variables)
            {
                if (ezrVar.Type == dataType)
                {
                    ListImgName.Add(ezrVar.Name);
                }
            }
            return ListImgName;
        }

        public Dictionary<string, List<string>> GetVariableDictionary(ProcessingEnvironment env)
        {
            Dictionary<string, List<string>> varDataPair = new Dictionary<string, List<string>>();
            foreach (DataType item in Enum.GetValues(typeof(DataType)))
            {
                List<string> listStr = GetVariableNames(item, env);
                varDataPair.Add(item.ToString(), listStr);
                //for (int i=0; i< GetVariableNames(item,env).Count; i++)
                //{
                //    listStr.Add();
                //    varDataPair.Add(item.ToString(), GetVariableNames(item, env)[i]);
                //}
                //item.ToString().Dump();
                //((int)item).Dump();
            }
            return varDataPair;
        }

        public void ExportVariableFiles(Dictionary<string, List<string>> keyValuePairs, ProcessingEnvironment env)
        {
            try
            {
                if (System.IO.Directory.Exists(@".\ExportVar"))
                {
                    Directory.Delete(@".\ExportVar", true);
                    System.IO.Directory.CreateDirectory(@".\ExportVar");
                }
                else
                {
                    System.IO.Directory.CreateDirectory(@".\ExportVar");
                }
                foreach (var item in keyValuePairs.Keys)
                {
                    System.IO.Directory.CreateDirectory(@".\ExportVar\" + item);
                    for (int i = 0; i < keyValuePairs[item].Count; i++)
                    {
                        List<string> tempVarName = new List<string>();
                        tempVarName.Add(keyValuePairs[item][i]);
                        env.SaveVariables(@".\ExportVar\" + item + @"\" + keyValuePairs[item][i]+ ".envar", tempVarName);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        Dictionary<string, List<string>> varDataPair = new Dictionary<string, List<string>>();
        private void btnLoadSourceEnv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "EzR File(*.env)|*.env|All Files(*.*)|*.*";
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                path_sourceEnv = openFileDialog.FileName;
                sourceEnv.Load(openFileDialog.FileName);
                RefreshItems(lsbSourceProgList, sourceEnv);
                varDataPair = GetVariableDictionary(sourceEnv);
                ExportVariableFiles(varDataPair, sourceEnv);
                //lsbSourceProgList.Items.Clear();
                //lsbSourceProgList.DataSource = 
            }
        }

        private void btnLoadTargetEnv_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "EzR File(*.env)|*.env|All Files(*.*)|*.*";
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                path_targetEnv = openFileDialog.FileName;
                targetEnv.Load(openFileDialog.FileName);
                RefreshItems(lsbTargetProgList, targetEnv);
            }
        }

        private void btnSource2Target_Click(object sender, EventArgs e)
        {
            if (lsbSourceProgList.Items.Count > 0 && lsbSourceProgList.SelectedItem != null)
            {
                int num = lsbSourceProgList.SelectedIndex;
                object selectedItem = lsbSourceProgList.SelectedItem;
                envTransferTool = new EnvTransferTool(sourceEnv, targetEnv);
                envTransferTool.CopyStepProgram(lsbSourceProgList.SelectedItem.ToString());
                RefreshItems(lsbTargetProgList, targetEnv);
            }

        }

        private void btnTarget2Source_Click(object sender, EventArgs e)
        {
            if (lsbTargetProgList.Items.Count > 0 && lsbTargetProgList.SelectedItem != null)
            {
                int num = lsbTargetProgList.SelectedIndex;
                object selectedItem = lsbTargetProgList.SelectedItem;
                envTransferTool = new EnvTransferTool(targetEnv,sourceEnv);
                envTransferTool.CopyStepProgram(lsbTargetProgList.SelectedItem.ToString());
                RefreshItems(lsbSourceProgList, sourceEnv);
            }
        }

        private void lsbSourceProgList_DoubleClick(object sender, EventArgs e)
        {
            btnSource2Target_Click(null, null);
        }

        private void lsbTargetProgList_DoubleClick(object sender, EventArgs e)
        {
            btnTarget2Source_Click(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Sure to save all env files", "Tip!", MessageBoxButtons.OKCancel))
            {               
                if (!System.IO.Directory.Exists(@".\ExportEnv"))
                {
                    System.IO.Directory.CreateDirectory(@".\ExportEnv");//不存在就创建目录
                }
                targetEnv.Save(@".\ExportEnv\" + GetFileName(path_targetEnv, "target.env"));
                sourceEnv.Save(@".\ExportEnv\" + GetFileName(path_sourceEnv, "source.env"));
            };
        }

        private string GetFileName(string filePath, string defaultName)
        {
            if(filePath!= "")
            {
                return Path.GetFileName(filePath);
            }
            else
            {
                return defaultName;
            }
        }

        private void lsbSourceProgList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (DialogResult.OK == MessageBox.Show("Sure to delete the selected item in EzR program?", "Tip!", MessageBoxButtons.OKCancel))
                {
                    if (lsbSourceProgList.Items.Count > 0 && lsbSourceProgList.SelectedItem != null)
                    {
                        sourceEnv.RemoveStepProgram(lsbSourceProgList.SelectedItem.ToString());
                        RefreshItems(lsbSourceProgList, sourceEnv);
                    }
                };
            }
        }

        private void lsbTargetProgList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (DialogResult.OK == MessageBox.Show("Sure to delete the selected item in EzR program?", "Tip!", MessageBoxButtons.OKCancel))
                {
                    if (lsbTargetProgList.Items.Count > 0 && lsbTargetProgList.SelectedItem != null)
                    {
                        targetEnv.RemoveStepProgram(lsbTargetProgList.SelectedItem.ToString());
                        RefreshItems(lsbTargetProgList, targetEnv);
                    }
                };
            }
        }
    }
}
