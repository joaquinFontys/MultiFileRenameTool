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

namespace MultiFileRenameTool
{
    public partial class Form1 : Form
    {
        String Path;
        FolderBrowserDialog folderDlg = new FolderBrowserDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void SelectPathBtn_Click(object sender, EventArgs e)
        {
            // Allows the user to sellect a path which then gets saved for later use
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                Path = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
                PathLbl.Text = Path;
            }
        }

        private void SubmitPathBtn_Click(object sender, EventArgs e)
        {
            ResetErrorLabel();
            if (Check(PathLbl.Text))
            {
                DirectoryInfo d = new DirectoryInfo(@Path);
                FileInfo[] infos = d.GetFiles();
                try
                {
                    foreach (FileInfo f in infos)
                    {
                        File.Move(f.FullName, f.FullName.Replace(WordToRemoveTxb.Text, "")); // Careful!! This will replaces the text "abc_" anywhere in the path, including directory names.
                    }
                }
                catch (ArgumentException)
                {
                    ErrorLbl.Text += "The Folder does not contain a file with the text that you entered";
                }
                
            }
        }

        private Boolean Check(String input)
        {
            // checks if the path that was selected was actually a valid path
            if (input == "Select a path")
            {
                ErrorLbl.Text = "No path was selected";
                return false;
            }
            return true;
        }

        private void ResetErrorLabel()
        {
            ErrorLbl.Text = "";
        }
    }
}
