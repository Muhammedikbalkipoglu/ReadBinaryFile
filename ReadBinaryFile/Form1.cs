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

            try
            {
                FileStream stream = new FileStream(path, FileMode.Open,
                    FileAccess.Read, FileShare.ReadWrite);

                using (BinaryReader reader = new BinaryReader(stream))
                {

                    binaryItemList.Items.Clear();
                    
                    binaryItemList.Items.Add("Char Value : " + reader.ReadChar());
                    
                    binaryItemList.Items.Add("Double Value : " + reader.ReadDouble());
                    
                    binaryItemList.Items.Add("Boolean Value : " + reader.ReadBoolean());
                    
                    binaryItemList.Items.Add("String Value : " + reader.ReadString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}

