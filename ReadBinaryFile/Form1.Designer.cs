namespace ReadBinaryFile
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPathFile = new System.Windows.Forms.TextBox();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnFindFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.binaryItemList = new System.Windows.Forms.ListBox();
            this.txttextTest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPathFile
            // 
            this.txtPathFile.Location = new System.Drawing.Point(164, 65);
            this.txtPathFile.Name = "txtPathFile";
            this.txtPathFile.Size = new System.Drawing.Size(304, 20);
            this.txtPathFile.TabIndex = 1;
            // 
            // btnReadFile
            // 
            this.btnReadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnReadFile.Location = new System.Drawing.Point(601, 65);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(75, 23);
            this.btnReadFile.TabIndex = 3;
            this.btnReadFile.Text = "ReadFile";
            this.btnReadFile.UseVisualStyleBackColor = false;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnFindFile
            // 
            this.btnFindFile.BackColor = System.Drawing.Color.Yellow;
            this.btnFindFile.Location = new System.Drawing.Point(499, 65);
            this.btnFindFile.Name = "btnFindFile";
            this.btnFindFile.Size = new System.Drawing.Size(75, 23);
            this.btnFindFile.TabIndex = 4;
            this.btnFindFile.Text = "FindFile";
            this.btnFindFile.UseVisualStyleBackColor = false;
            this.btnFindFile.Click += new System.EventHandler(this.btnFindFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // binaryItemList
            // 
            this.binaryItemList.FormattingEnabled = true;
            this.binaryItemList.Location = new System.Drawing.Point(164, 124);
            this.binaryItemList.Name = "binaryItemList";
            this.binaryItemList.Size = new System.Drawing.Size(512, 264);
            this.binaryItemList.TabIndex = 5;
            // 
            // txttextTest
            // 
            this.txttextTest.Location = new System.Drawing.Point(164, 13);
            this.txttextTest.Name = "txttextTest";
            this.txttextTest.Size = new System.Drawing.Size(512, 20);
            this.txttextTest.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttextTest);
            this.Controls.Add(this.binaryItemList);
            this.Controls.Add(this.btnFindFile);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.txtPathFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPathFile;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnFindFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox binaryItemList;
        private System.Windows.Forms.TextBox txttextTest;
    }
}

