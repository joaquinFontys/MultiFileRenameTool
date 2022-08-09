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
        Directory directory;
        String Path;
        FolderBrowserDialog folderDlg = new FolderBrowserDialog();
        List<Directory> fileTree = new List<Directory>();
        List<Directory> temporaryFileTree = new List<Directory>();
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
            renameFilesInSpecificFolder(Path);
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

        private void testBtn_Click(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(@Path);
            directory = new Directory(d.GetFiles(), d.GetDirectories(), @Path);
            fileTree.Add(directory);

            collectSubDirectories();

            foreach(Directory dr in fileTree){
                renameFilesInSpecificFolder(dr.path);
            }
        }

        public void renameFilesInSpecificFolder(String path)
        {
            ResetErrorLabel();
            if (Check(PathLbl.Text))
            {
                DirectoryInfo d = new DirectoryInfo(@path);
                FileInfo[] infos = d.GetFiles();
                try
                {
                    int version = 1;
                    foreach (FileInfo f in infos)
                    {                        
                        try
                        {
                            File.Move(f.FullName, f.FullName.Replace(WordToRemoveTxb.Text, ""));
                        }
                        catch (System.IO.IOException)
                        {
                            File.Move(f.FullName, f.FullName.Replace(WordToRemoveTxb.Text, " " + version));
                            version++;
                        }
                    }
                    
                }
                catch (ArgumentException)
                {
                    ErrorLbl.Text += "The Folder does not contain a file with the text that you entered";
                }
                
                //catch (file)
                //{

                //}

            }
        }

        private void collectSubDirectories()
        {
            int j = 1;
            for (int i = 0; i < j; i++)
            {
                foreach (Directory dir in fileTree)
                {
                    if (dir.notClear)
                    {
                        Boolean anotherLapNeeded = false;
                        foreach (DirectoryInfo di in dir.dirs)
                        {
                            directory = new Directory(di.GetFiles(), di.GetDirectories(), di.FullName);
                            temporaryFileTree.Add(directory);
                            anotherLapNeeded = true;
                        }

                        if (anotherLapNeeded)
                        {
                            j++;
                        }

                        dir.notClear = false;
                    }
                }

                foreach (Directory dir in temporaryFileTree)
                {
                    fileTree.Add(dir);
                }

                temporaryFileTree.Clear();

            }
            
            Console.WriteLine("test");
            //foreach (FileInfo f in fileTree.ElementAt(0).infos)
            //{
            //    File.Move(f.FullName, f.FullName.Replace(WordToRemoveTxb.Text, ""));
            //}         
        }
    }
}
