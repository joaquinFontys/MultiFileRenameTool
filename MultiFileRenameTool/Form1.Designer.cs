
namespace MultiFileRenameTool
{
    partial class MultiFileRenameTool
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiFileRenameTool));
            this.PathLbl = new System.Windows.Forms.Label();
            this.WordToRemoveTxb = new System.Windows.Forms.TextBox();
            this.ErrorLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.SelectPathBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SubmitPathBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.allFoldersBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.wordToRemoveLbl = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // PathLbl
            // 
            this.PathLbl.AutoSize = true;
            this.PathLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PathLbl.Location = new System.Drawing.Point(141, 186);
            this.PathLbl.Name = "PathLbl";
            this.PathLbl.Size = new System.Drawing.Size(83, 17);
            this.PathLbl.TabIndex = 0;
            this.PathLbl.Text = "Select a path";
            // 
            // WordToRemoveTxb
            // 
            this.WordToRemoveTxb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordToRemoveTxb.Location = new System.Drawing.Point(141, 135);
            this.WordToRemoveTxb.Name = "WordToRemoveTxb";
            this.WordToRemoveTxb.Size = new System.Drawing.Size(274, 23);
            this.WordToRemoveTxb.TabIndex = 2;
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.ErrorLbl.Location = new System.Drawing.Point(12, 257);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(16, 17);
            this.ErrorLbl.TabIndex = 4;
            this.ErrorLbl.Text = "V";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLbl.Location = new System.Drawing.Point(12, 82);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(635, 48);
            this.DescriptionLbl.TabIndex = 6;
            this.DescriptionLbl.Text = resources.GetString("DescriptionLbl.Text");
            // 
            // SelectPathBtn
            // 
            this.SelectPathBtn.AutoSize = true;
            this.SelectPathBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SelectPathBtn.Depth = 0;
            this.SelectPathBtn.Icon = null;
            this.SelectPathBtn.Location = new System.Drawing.Point(12, 167);
            this.SelectPathBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SelectPathBtn.Name = "SelectPathBtn";
            this.SelectPathBtn.Primary = true;
            this.SelectPathBtn.Size = new System.Drawing.Size(123, 36);
            this.SelectPathBtn.TabIndex = 8;
            this.SelectPathBtn.Text = "Select Folder";
            this.SelectPathBtn.UseVisualStyleBackColor = true;
            this.SelectPathBtn.Click += new System.EventHandler(this.SelectPathBtn_Click);
            // 
            // SubmitPathBtn
            // 
            this.SubmitPathBtn.AutoSize = true;
            this.SubmitPathBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SubmitPathBtn.Depth = 0;
            this.SubmitPathBtn.Icon = null;
            this.SubmitPathBtn.Location = new System.Drawing.Point(12, 209);
            this.SubmitPathBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SubmitPathBtn.Name = "SubmitPathBtn";
            this.SubmitPathBtn.Primary = true;
            this.SubmitPathBtn.Size = new System.Drawing.Size(101, 36);
            this.SubmitPathBtn.TabIndex = 9;
            this.SubmitPathBtn.Text = "Top folder";
            this.SubmitPathBtn.UseVisualStyleBackColor = true;
            this.SubmitPathBtn.Click += new System.EventHandler(this.SubmitPathBtn_Click_1);
            // 
            // allFoldersBtn
            // 
            this.allFoldersBtn.AutoSize = true;
            this.allFoldersBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allFoldersBtn.Depth = 0;
            this.allFoldersBtn.Icon = null;
            this.allFoldersBtn.Location = new System.Drawing.Point(119, 209);
            this.allFoldersBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.allFoldersBtn.Name = "allFoldersBtn";
            this.allFoldersBtn.Primary = true;
            this.allFoldersBtn.Size = new System.Drawing.Size(106, 36);
            this.allFoldersBtn.TabIndex = 10;
            this.allFoldersBtn.Text = "All folders ";
            this.allFoldersBtn.UseVisualStyleBackColor = true;
            this.allFoldersBtn.Click += new System.EventHandler(this.allFoldersBtn_Click);
            // 
            // wordToRemoveLbl
            // 
            this.wordToRemoveLbl.AutoSize = true;
            this.wordToRemoveLbl.Depth = 0;
            this.wordToRemoveLbl.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wordToRemoveLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wordToRemoveLbl.Location = new System.Drawing.Point(12, 139);
            this.wordToRemoveLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.wordToRemoveLbl.Name = "wordToRemoveLbl";
            this.wordToRemoveLbl.Size = new System.Drawing.Size(120, 19);
            this.wordToRemoveLbl.TabIndex = 11;
            this.wordToRemoveLbl.Text = "Word to remove:";
            // 
            // MultiFileRenameTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wordToRemoveLbl);
            this.Controls.Add(this.allFoldersBtn);
            this.Controls.Add(this.SubmitPathBtn);
            this.Controls.Add(this.SelectPathBtn);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.ErrorLbl);
            this.Controls.Add(this.WordToRemoveTxb);
            this.Controls.Add(this.PathLbl);
            this.Name = "MultiFileRenameTool";
            this.Text = "Multi File Rename Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PathLbl;
        private System.Windows.Forms.TextBox WordToRemoveTxb;
        private System.Windows.Forms.Label ErrorLbl;
        private System.Windows.Forms.Label DescriptionLbl;
        private MaterialSkin.Controls.MaterialRaisedButton SelectPathBtn;
        private MaterialSkin.Controls.MaterialRaisedButton SubmitPathBtn;
        private MaterialSkin.Controls.MaterialRaisedButton allFoldersBtn;
        private MaterialSkin.Controls.MaterialLabel wordToRemoveLbl;
    }
}

