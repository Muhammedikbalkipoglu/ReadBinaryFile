using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReadBinaryFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            readTofile();
        }

        private void btnFindFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPathFile.Text = openFileDialog1.FileName;
            }
        }

        private void readTofile()
        {
            string path = txtPathFile.Text;
            //char[] invalidPathChars= path.ToCharArray();
            try
            {
                FileStream stream = new FileStream(path, FileMode.Open,
                    FileAccess.Read, FileShare.ReadWrite);

                using (BinaryReader reader = new BinaryReader(stream))
                {
                                        
                    int pos = 73;
                    int required = 32;

                    reader.BaseStream.Seek(pos, SeekOrigin.Begin);

                   
                    byte[] by = reader.ReadBytes(required);
                    string str = System.Text.Encoding.ASCII.GetString(by);
                    MessageBox.Show(str);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}

