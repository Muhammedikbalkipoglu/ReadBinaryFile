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

            try
            {
                FileStream stream = new FileStream(path, FileMode.Open,
                    FileAccess.Read, FileShare.ReadWrite);

                using (BinaryReader reader = new BinaryReader(stream))
                {
                    byte[] bytList = reader.ReadBytes((int)reader.BaseStream.Length);
                    int pos = 0;
                    int required = 0;

                    for (int i = 0; i < bytList.Length; i++)
                    {
                        pos = i;

                        switch (pos)
                        {
                            case 0:
                                required = 1;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                dataGridViewBinaryData.Rows.Add("FLAG/Enable", reader.ReadBoolean());
                                break;
                            case 1:
                                required = 6;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by = reader.ReadBytes(required);
                                string str = System.Text.Encoding.ASCII.GetString(by);
                                dataGridViewBinaryData.Rows.Add("FLAG/Reserved", str);
                                break;
                            case 7:
                                required = 1;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                dataGridViewBinaryData.Rows.Add("FLAG/Available", reader.ReadBoolean());
                                break;
                            case 9:
                                required = 32;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by1 = reader.ReadBytes(required);
                                string str1 = System.Text.Encoding.ASCII.GetString(by1);
                                dataGridViewBinaryData.Rows.Add("HEADER/Manufacturer", str1);
                                break;
                            case 41:
                                required = 32;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by2 = reader.ReadBytes(required);
                                string str2 = System.Text.Encoding.ASCII.GetString(by2);
                                dataGridViewBinaryData.Rows.Add("HEADER/Company", str2);
                                break;
                            case 73:
                                required = 32;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by3 = reader.ReadBytes(required);
                                string str3 = System.Text.Encoding.ASCII.GetString(by3);
                                dataGridViewBinaryData.Rows.Add("HEADER/Station", str3);
                                break;
                            case 105:
                                required = 32;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by4 = reader.ReadBytes(required);
                                string str4 = System.Text.Encoding.ASCII.GetString(by4);
                                dataGridViewBinaryData.Rows.Add("HEADER/Operator", str4);
                                break;
                            case 137:
                                required = 32;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by5 = reader.ReadBytes(required);
                                string str5 = System.Text.Encoding.ASCII.GetString(by5);
                                dataGridViewBinaryData.Rows.Add("HEADER/Model", str5);
                                break;
                            case 169:
                                required = 32;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by6 = reader.ReadBytes(required);
                                string str6 = System.Text.Encoding.ASCII.GetString(by6);
                                dataGridViewBinaryData.Rows.Add("HEADER/Serial", str6);
                                break;
                            case 201:
                                required = 32;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by7 = reader.ReadBytes(required);
                                string str7 = System.Text.Encoding.ASCII.GetString(by7);
                                dataGridViewBinaryData.Rows.Add("HEADER/Version", str7);
                                break;
                            case 232:
                                required = 33;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by8 = reader.ReadBytes(required);
                                string str8 = System.Text.Encoding.ASCII.GetString(by8);
                                dataGridViewBinaryData.Rows.Add("HEADER/Name", str8);
                                break;
                            case 265:
                                required = 3;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by9 = reader.ReadBytes(required);
                                string str9 = System.Text.Encoding.ASCII.GetString(by9);
                                dataGridViewBinaryData.Rows.Add("HEADER/Reserved", str9);
                                break;
                            case 268:
                                required = 1;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);

                                if (reader.ReadInt32() == 0)
                                {
                                    dataGridViewBinaryData.Rows.Add("TEST TYPE/Test Type", "UNKNOWN");
                                }
                                if (reader.ReadInt32() == 1)
                                {
                                    dataGridViewBinaryData.Rows.Add("TEST TYPE/Test Type", " Injection Test");
                                }
                                if (reader.ReadInt32() == 2)
                                {
                                    dataGridViewBinaryData.Rows.Add("TEST TYPE/Test Type", "Ratio Test");
                                }
                                if (reader.ReadInt32() == 3)
                                {
                                    dataGridViewBinaryData.Rows.Add("TEST TYPE/Test Type", "Auto Test");
                                }
                                break;
                            case 269:
                                required = 3;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by10 = reader.ReadBytes(required);
                                string str10 = System.Text.Encoding.ASCII.GetString(by10);
                                dataGridViewBinaryData.Rows.Add("TEST TYPE/Reserved", str10);
                                break;
                            case 272:
                                required = 1;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                if (reader.ReadInt32() == 0)
                                {
                                    dataGridViewBinaryData.Rows.Add("START CONDITION PARAM/Type", "Internal");
                                }
                                if (reader.ReadInt32() == 1)
                                {
                                    dataGridViewBinaryData.Rows.Add("START CONDITION PARAM/Type", "External");
                                }
                                if (reader.ReadInt32() == 2)
                                {
                                    dataGridViewBinaryData.Rows.Add("START CONDITION PARAM/Type", "Continuous");
                                }
                                break;
                            case 273:
                                required = 3;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by11 = reader.ReadBytes(required);
                                string str11 = System.Text.Encoding.ASCII.GetString(by11);
                                dataGridViewBinaryData.Rows.Add("START CONDITION PARAM/Reserved", str11);
                                break;
                            case 276:
                                required = 1;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                if (reader.ReadInt32() == 0)
                                {
                                    dataGridViewBinaryData.Rows.Add("START CONDITION PARAM/Mode", "Dry");
                                }
                                if (reader.ReadInt32() == 1)
                                {
                                    dataGridViewBinaryData.Rows.Add("START CONDITION PARAM/Mode", "Wet");
                                }
                                break;
                            case 277:
                                required = 3;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by12 = reader.ReadBytes(required);
                                string str12 = System.Text.Encoding.ASCII.GetString(by12);
                                dataGridViewBinaryData.Rows.Add("START CONDITION PARAM/Reserved", str12);
                                break;
                            case 281:
                                required = 1;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                if (reader.ReadInt32() == 0)
                                {
                                    dataGridViewBinaryData.Rows.Add("START CONDITION PARAM/Edge", "NO");
                                }
                                if (reader.ReadInt32() == 1)
                                {
                                    dataGridViewBinaryData.Rows.Add("START CONDITION PARAM/Edge", "NC");
                                }
                                if (reader.ReadInt32() == 2)
                                {
                                    dataGridViewBinaryData.Rows.Add("START CONDITION PARAM/Edge", "Auto");
                                }
                                break;
                            case 282:
                                required = 3;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by13 = reader.ReadBytes(required);
                                string str13 = System.Text.Encoding.ASCII.GetString(by13);
                                dataGridViewBinaryData.Rows.Add("START CONDITION PARAM/Reserved", str13);
                                break;
                            case 284:
                                required = 1;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                if (reader.ReadInt32() == 0)
                                {
                                    dataGridViewBinaryData.Rows.Add("STOP CONDITION PARAM/Type", "Internal");
                                }
                                if (reader.ReadInt32() == 1)
                                {
                                    dataGridViewBinaryData.Rows.Add("STOP CONDITION PARAM/Type", "External");
                                }
                                if (reader.ReadInt32() == 2)
                                {
                                    dataGridViewBinaryData.Rows.Add("STOP CONDITION PARAM/Type", "Continuous");
                                }
                                break;
                            case 285:
                                required = 3;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by14 = reader.ReadBytes(required);
                                string str14 = System.Text.Encoding.ASCII.GetString(by14);
                                dataGridViewBinaryData.Rows.Add("STOP CONDITION PARAM/Reserved", by14);
                                break;
                            case 288:
                                required = 1;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                if (reader.ReadInt32() == 0)
                                {
                                    dataGridViewBinaryData.Rows.Add("STOP CONDITION PARAM/Mode", "Dry");
                                }
                                if (reader.ReadInt32() == 1)
                                {
                                    dataGridViewBinaryData.Rows.Add("STOP CONDITION PARAM/Mode", "Wet");
                                }
                                break;
                            case 289:
                                required = 3;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by15 = reader.ReadBytes(required);
                                string str15 = System.Text.Encoding.ASCII.GetString(by15);
                                dataGridViewBinaryData.Rows.Add("STOP CONDITION PARAM/Reserved", str15);
                                break;
                            case 292:
                                required = 1;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                if (reader.ReadInt32() == 0)
                                {
                                    dataGridViewBinaryData.Rows.Add("STOP CONDITION PARAM/Edge", "NO");
                                }
                                if (reader.ReadInt32() == 1)
                                {
                                    dataGridViewBinaryData.Rows.Add("STOP CONDITION PARAM/Edge", "NC");
                                }
                                if (reader.ReadInt32() == 2)
                                {
                                    dataGridViewBinaryData.Rows.Add("STOP CONDITION PARAM/Edge", "Auto");
                                }
                                break;
                            case 294:
                                required = 3;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by16 = reader.ReadBytes(required);
                                string str16 = System.Text.Encoding.ASCII.GetString(by16);
                                dataGridViewBinaryData.Rows.Add("STOP CONDITION PARAM/Reserved", str16);
                                break;
                            case 296:
                                required = 1;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                dataGridViewBinaryData.Rows.Add("PASS/FAIL PARAM/Available", reader.ReadBoolean());
                                break;
                            case 297:
                                required = 7;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by17 = reader.ReadBytes(required);
                                string str17 = System.Text.Encoding.ASCII.GetString(by17);
                                dataGridViewBinaryData.Rows.Add("PASS/FAIL PARAM/Reserved", str17);
                                break;
                            case 305:
                                required = 8;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by18 = reader.ReadBytes(required);
                                dataGridViewBinaryData.Rows.Add("PASS/FAIL PARAM/Upper Limit", reader.ReadDouble() + "   " + "(in second)");
                                break;
                            case 312:
                                required = 8;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by19 = reader.ReadBytes(required);
                                dataGridViewBinaryData.Rows.Add("PASS/FAIL PARAM/Lower Limit", reader.ReadDouble() + "   " + "(in second)");
                                break;
                            case 320:
                                required = 2;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by20 = reader.ReadBytes(required);
                                string str21 = System.Text.Encoding.ASCII.GetString(by20);
                                dataGridViewBinaryData.Rows.Add("INJECTIO PARAM/Current", str21);
                                break;
                            case 322:
                                required = 2;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by22 = reader.ReadBytes(required);
                                string str22 = System.Text.Encoding.ASCII.GetString(by22);
                                dataGridViewBinaryData.Rows.Add("INJECTIO PARAM/Reserved", str22);
                                break;
                            case 324:
                                required = 1;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by23 = reader.ReadBytes(required);
                                if (reader.ReadByte() == 0)
                                {
                                    dataGridViewBinaryData.Rows.Add("INJECTIO PARAM/Frequency", "50Hz");
                                }
                                if (reader.ReadByte() == 1)
                                {
                                    dataGridViewBinaryData.Rows.Add("INJECTIO PARAM/Frequency", "60Hz");
                                }
                                break;
                            case 325:
                                required = 1;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by24 = reader.ReadBytes(required);
                                string str24 = System.Text.Encoding.ASCII.GetString(by24);
                                dataGridViewBinaryData.Rows.Add("INJECTIO PARAM/Reserved", str24);
                                break;
                            case 328:
                                required = 1;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by25 = reader.ReadBytes(required);
                                dataGridViewBinaryData.Rows.Add("INJECTIO PARAM/Frequency Value", reader.ReadByte() + "  " + "( in Hz )");
                                break;
                            case 329:
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                dataGridViewBinaryData.Rows.Add("INJECTIO PARAM/Turn Number", reader.ReadInt32());
                                break;
                            case 330:
                                required = 6;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by26 = reader.ReadBytes(required);
                                string str26 = System.Text.Encoding.ASCII.GetString(by26);
                                dataGridViewBinaryData.Rows.Add("INJECTIO PARAM/Reserved", str26);
                                break;
                            case 336:
                                required = 8;
                                reader.BaseStream.Seek(pos, SeekOrigin.Begin);
                                byte[] by27 = reader.ReadBytes(required);
                                dataGridViewBinaryData.Rows.Add("INJECTIO PARAM/T max", reader.ReadDouble() + "   " + "(in second)");
                                break;
                        }


                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void readDataBinaryToAscii(string path, int pos, int required)
        {

        }
    }
}

