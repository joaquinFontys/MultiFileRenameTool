
namespace MultiFileRenameTool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PathLbl = new System.Windows.Forms.Label();
            this.SelectPathBtn = new System.Windows.Forms.Button();
            this.WordToRemoveTxb = new System.Windows.Forms.TextBox();
            this.SubmitPathBtn = new System.Windows.Forms.Button();
            this.ErrorLbl = new System.Windows.Forms.Label();
            this.testBtn = new System.Windows.Forms.Button();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PathLbl
            // 
            this.PathLbl.AutoSize = true;
            this.PathLbl.Location = new System.Drawing.Point(13, 111);
            this.PathLbl.Name = "PathLbl";
            this.PathLbl.Size = new System.Drawing.Size(74, 15);
            this.PathLbl.TabIndex = 0;
            this.PathLbl.Text = "Select a path";
            // 
            // SelectPathBtn
            // 
            this.SelectPathBtn.Location = new System.Drawing.Point(12, 85);
            this.SelectPathBtn.Name = "SelectPathBtn";
            this.SelectPathBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectPathBtn.TabIndex = 1;
            this.SelectPathBtn.Text = "Select Path";
            this.SelectPathBtn.UseVisualStyleBackColor = true;
            this.SelectPathBtn.Click += new System.EventHandler(this.SelectPathBtn_Click);
            // 
            // WordToRemoveTxb
            // 
            this.WordToRemoveTxb.Location = new System.Drawing.Point(13, 128);
            this.WordToRemoveTxb.Name = "WordToRemoveTxb";
            this.WordToRemoveTxb.Size = new System.Drawing.Size(100, 23);
            this.WordToRemoveTxb.TabIndex = 2;
            // 
            // SubmitPathBtn
            // 
            this.SubmitPathBtn.Location = new System.Drawing.Point(93, 85);
            this.SubmitPathBtn.Name = "SubmitPathBtn";
            this.SubmitPathBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitPathBtn.TabIndex = 3;
            this.SubmitPathBtn.Text = "Submit";
            this.SubmitPathBtn.UseVisualStyleBackColor = true;
            this.SubmitPathBtn.Click += new System.EventHandler(this.SubmitPathBtn_Click);
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.ErrorLbl.Location = new System.Drawing.Point(135, 183);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(0, 15);
            this.ErrorLbl.TabIndex = 4;
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(174, 85);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 5;
            this.testBtn.Text = "Test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLbl.Location = new System.Drawing.Point(12, 34);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(635, 48);
            this.DescriptionLbl.TabIndex = 6;
            this.DescriptionLbl.Text = resources.GetString("DescriptionLbl.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.ErrorLbl);
            this.Controls.Add(this.SubmitPathBtn);
            this.Controls.Add(this.WordToRemoveTxb);
            this.Controls.Add(this.SelectPathBtn);
            this.Controls.Add(this.PathLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PathLbl;
        private System.Windows.Forms.Button SelectPathBtn;
        private System.Windows.Forms.TextBox WordToRemoveTxb;
        private System.Windows.Forms.Button SubmitPathBtn;
        private System.Windows.Forms.Label ErrorLbl;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Label DescriptionLbl;
    }
}

