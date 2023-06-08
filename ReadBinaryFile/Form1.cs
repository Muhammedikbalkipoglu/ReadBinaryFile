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

                    //binaryItemList.Items.Clear();

                    //binaryItemList.Items.Add("Byte22 Value : " + reader.Read(invalidPathChars,0,0));

                    //binaryItemList.Items.Add("Byte Value : " + reader.ReadBytes(6));

                    //binaryItemList.Items.Add("Char Value : " + reader.ReadChars(10));

                    //binaryItemList.Items.Add("Double Value : " + reader.ReadDouble());

                    //binaryItemList.Items.Add("Boolean Value : " + reader.ReadBoolean());

                    //binaryItemList.Items.Add("String Value : " + reader.ReadString());
                    //int a = 0;
                    //int sayac = 0;
                    //Byte[] icerik = new Byte[stream.Length];

                    //while (a > -1) 
                    //{
                    //   a = reader.ReadByte();
                    //    if (a != -1) 
                    //    {
                    //        icerik[sayac] = (Byte)a;
                    //    }
                    //    sayac++;
                    //}

                    ////reader.BaseStream.Position = 0;
                    //txttextTest.Text = (Encoding.GetEncoding("iso-8859-9").GetString(icerik));

                    //int arrayLength = 1;
                    //byte[] dataArray = new byte[arrayLength];
                    //byte[] verifyArray = new byte[arrayLength];

                    // reader.BaseStream.Position = 268 ;

                    //MessageBox.Show (reader.ReadChar().ToString());
                    //reader.BaseStream.Seek(9, SeekOrigin.Begin);
                    //stream.Seek(45, SeekOrigin.Begin);
                    //int read = stream.ReadByte();
                    //reader.BaseStream.Position = 41;

                    //reader.BaseStream.Position = 0xB0;
                    //byte[] array = reader.ReadBytes(0xC);
                    //long value0 = long.Parse(ASCIIEncoding.ASCII.GetString(array));
                    //string value1 = value0.ToString();
                    //txttextTest.Text = value1;

                    //MessageBox.Show (with.ToString(),height.ToString());

                    //int length = (int)reader.BaseStream.Length;
                    //int pos = 40;
                    //int required = 32;
                    //int count = 0;
                    //ArrayList arrayList = new ArrayList();
                    //reader.BaseStream.Position = pos;
                    // Seek the required index.
                    //reader.BaseStream.Seek(pos, SeekOrigin.Begin);

                    // Slow loop through the bytes.
                    //while (pos < length && count < required)
                    //{
                    //    byte y = reader.ReadByte();
                    //    arrayList.Add(y);
                    //    pos++;
                    //    count++;

                    //}
                    //byte[] obj = arrayList.OfType<byte>().ToArray();
                    //string str = System.Text.Encoding.ASCII.GetString(obj);
                    //MessageBox.Show(str);

                    int pos = 73;
                    int required = 32;

                    reader.BaseStream.Seek(pos, SeekOrigin.Begin);

                    // Read the next 2000 bytes.
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

