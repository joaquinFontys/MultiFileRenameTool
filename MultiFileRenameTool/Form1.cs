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
using MaterialSkin;
using MaterialSkin.Controls;

namespace MultiFileRenameTool
{
    public partial class MultiFileRenameTool : MaterialForm
    {
        Directory directory;
        string rootPath;
        FolderBrowserDialog folderDlg = new FolderBrowserDialog();
        // Lists used for renaming files in multiple sub folders
        List<Directory> fileTree = new List<Directory>();
        List<Directory> temporaryFileTree = new List<Directory>();

        public MultiFileRenameTool()
        {
            InitializeComponent();
            // we load in the custom theme here
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void allFoldersBtn_Click(object sender, EventArgs e)
        {
            // uses the directory locations obtained by the coolecSubDirectories method and uses them in a method that renames files
            try
            {
                //setting the top directory as the first element of the fileTree list
                DirectoryInfo d = new DirectoryInfo(rootPath);
                directory = new Directory(d.GetFiles(), d.GetDirectories(), rootPath);
                fileTree.Add(directory);
                //now we will collect all the directories starting from the top directory
                collectSubDirectories();
                // now we rename the files in all these directories one by one
                foreach (Directory dr in fileTree)
                {
                    renameFilesInSpecificFolderAsync(dr.path);
                }
            }
            catch (ArgumentNullException)
            {
                ErrorLbl.Text += "Please select a path";
            }
        }

        private void SelectPathBtn_Click(object sender, EventArgs e)
        {
            // Allows the user to sellect a path which then gets saved for later use
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                rootPath = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
                PathLbl.Text = rootPath;
            }
        }

        private void SubmitPathBtn_Click_1(object sender, EventArgs e)
        {
            renameFilesInSpecificFolderAsync(rootPath);
        }

        private Boolean Check(String input)
        {
            // checks if the path that was selected was actually a valid path
            if (input == "Select a path")
            {
                ErrorLbl.Text = "No path was selected";
                return false;
            }
            // checks if the word doesnt have a . in it because it would break files if it did
            if (WordToRemoveTxb.Text.EndsWith("."))
            {
                ErrorLbl.Text = ("Are you sure you want to use this term? This could potentially break files");
                return false;
            }
            return true;
        }

        private void ResetErrorLabel()
        {
            // resets the error notificator label back to a state where nothing is in it
            ErrorLbl.Text = "";
        }

        public async Task renameFilesInSpecificFolderAsync(String path)
        {
            // uses a specific path and renames all the files there to not have a user provided word or sentence
            ResetErrorLabel();

            if (Check(PathLbl.Text))
            {
                //aitaining information about the files that are at the path 
                DirectoryInfo d = new DirectoryInfo(@path);
                FileInfo[] infos = d.GetFiles();
                // just a number to put in the file incase it already exists within the folder
                string textFilePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\Files\\number.txt";
                long version = Int64.Parse(System.IO.File.ReadAllText(@textFilePath));
                foreach (FileInfo f in infos)
                {                        
                    try
                    {
                        // this is the part where it actually changes the files name
                        File.Move(f.FullName, f.FullName.Replace(WordToRemoveTxb.Text, ""));
                    }
                    catch (System.IO.IOException)
                    {
                        // here we change the files name to something with a number in case it is duplicate
                        File.Move(f.FullName, f.FullName.Replace(WordToRemoveTxb.Text, " " + version));
                        version++;
                        await File.WriteAllTextAsync(@textFilePath, version.ToString());
                    }
                    catch (ArgumentException)
                    {
                        ErrorLbl.Text += "The Folder does not contain a file with the text that you entered";
                    }
                }                       
            }
        }

        private void collectSubDirectories()
        {
            // TODO: document and refactor this function
            int j = 1;
            for (int i = 0; i < j; i++)
            {
                foreach (Directory dir in fileTree)
                {
                    if (dir.notClear)
                    {
                        foreach (DirectoryInfo di in dir.dirs)
                        {
                            directory = new Directory(di.GetFiles(), di.GetDirectories(), di.FullName);
                            temporaryFileTree.Add(directory);
                        }
                        j++;
                        dir.notClear = false;
                    }
                }

                foreach (Directory dir in temporaryFileTree)
                {
                    fileTree.Add(dir);
                }

                temporaryFileTree.Clear();

            }
        }
    }
}
