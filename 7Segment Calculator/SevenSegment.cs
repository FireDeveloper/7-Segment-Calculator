using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace _7Segment_Calculator {
    public partial class SevenSegment : Form {
        public SevenSegment() {
            InitializeComponent();
        }

        uint[] ports = new uint[] { 1, 2, 4, 8, 16, 32, 64, 128 };
        bool[] btns = new bool[] { false, false, false, false, false, false, false, false };
        //abcdefgp
        //A=65
        byte _Size = 8;

        private void textBox1_TextChanged(object sender, EventArgs e) {
            try {
                uint pos = Convert.ToUInt32(textBox1.Text);
                ports[0] = Convert.ToUInt32(Math.Pow(2, pos));
                textBox1.ForeColor = Color.Black;
                DisplayResult();
            } catch (Exception) {
                label9.Visible = true;
                textBox1.ForeColor = Color.Red;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            try {
                uint pos = Convert.ToUInt32(textBox2.Text);
                ports[1] = Convert.ToUInt32(Math.Pow(2, pos));
                textBox2.ForeColor = Color.Black;
                DisplayResult();
            } catch (Exception) {
                label9.Visible = true;
                textBox2.ForeColor = Color.Red;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {
            try {
                uint pos = Convert.ToUInt32(textBox3.Text);
                ports[2] = Convert.ToUInt32(Math.Pow(2, pos));
                textBox3.ForeColor = Color.Black;
                DisplayResult();
            } catch (Exception) {
                label9.Visible = true;
                textBox3.ForeColor = Color.Red;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e) {
            try {
                uint pos = Convert.ToUInt32(textBox4.Text);
                ports[3] = Convert.ToUInt32(Math.Pow(2, pos));
                textBox4.ForeColor = Color.Black;
                DisplayResult();
            } catch (Exception) {
                label9.Visible = true;
                textBox4.ForeColor = Color.Red;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e) {
            try {
                uint pos = Convert.ToUInt32(textBox5.Text);
                ports[4] = Convert.ToUInt32(Math.Pow(2, pos));
                textBox5.ForeColor = Color.Black;
                DisplayResult();
            } catch (Exception) {
                label9.Visible = true;
                textBox5.ForeColor = Color.Red;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e) {
            try {
                uint pos = Convert.ToUInt32(textBox6.Text);
                ports[5] = Convert.ToUInt32(Math.Pow(2, pos));
                textBox6.ForeColor = Color.Black;
                DisplayResult();
            } catch (Exception) {
                label9.Visible = true;
                textBox6.ForeColor = Color.Red;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e) {
            try {
                uint pos = Convert.ToUInt32(textBox7.Text);
                ports[6] = Convert.ToUInt32(Math.Pow(2, pos));
                textBox7.ForeColor = Color.Black;
                DisplayResult();
            } catch (Exception) {
                label9.Visible = true;
                textBox7.ForeColor = Color.Red;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e) {
            try {
                uint pos = Convert.ToUInt32(textBox8.Text);
                ports[7] = Convert.ToUInt32(Math.Pow(2, pos));
                textBox8.ForeColor = Color.Black;
                DisplayResult();
            } catch (Exception) {
                label9.Visible = true;
                textBox8.ForeColor = Color.Red;
            }
        }



        private void button1_Click(object sender, EventArgs e) {
            if (!btns[0])
                button1.BackColor = Color.Red;
            else
                button1.BackColor = Color.Silver;
            btns[0] = !btns[0];
            DisplayResult();
        }


        private void button2_Click(object sender, EventArgs e) {
            if (!btns[1])
                button2.BackColor = Color.Red;
            else
                button2.BackColor = Color.Silver;
            btns[1] = !btns[1];
            DisplayResult();
        }

        private void button3_Click(object sender, EventArgs e) {
            if (!btns[2])
                button3.BackColor = Color.Red;
            else
                button3.BackColor = Color.Silver;
            btns[2] = !btns[2];
            DisplayResult();
        }

        private void button4_Click(object sender, EventArgs e) {
            if (!btns[3])
                button4.BackColor = Color.Red;
            else
                button4.BackColor = Color.Silver;
            btns[3] = !btns[3];
            DisplayResult();
        }

        private void button5_Click(object sender, EventArgs e) {
            if (!btns[4])
                button5.BackColor = Color.Red;
            else
                button5.BackColor = Color.Silver;
            btns[4] = !btns[4];
            DisplayResult();
        }

        private void button6_Click(object sender, EventArgs e) {
            if (!btns[5])
                button6.BackColor = Color.Red;
            else
                button6.BackColor = Color.Silver;
            btns[5] = !btns[5];
            DisplayResult();
        }

        private void button7_Click(object sender, EventArgs e) {
            if (!btns[6])
                button7.BackColor = Color.Red;
            else
                button7.BackColor = Color.Silver;
            btns[6] = !btns[6];
            DisplayResult();
        }

        private void button8_Click(object sender, EventArgs e) {
            if (!btns[7])
                button8.BackColor = Color.Red;
            else
                button8.BackColor = Color.Silver;
            btns[7] = !btns[7];
            DisplayResult();
        }

        private void DisplayResult() {
            if (OverUseCheck()) {
                label9.Visible = true;
                return;
            }
            label9.Visible = false;
            uint res = 0;
            res += (btns[0]) ? ports[0] : 0;
            res += (btns[1]) ? ports[1] : 0;
            res += (btns[2]) ? ports[2] : 0;
            res += (btns[3]) ? ports[3] : 0;
            res += (btns[4]) ? ports[4] : 0;
            res += (btns[5]) ? ports[5] : 0;
            res += (btns[6]) ? ports[6] : 0;
            res += (btns[7]) ? ports[7] : 0;
            convert(res);

            if (radioButton1.Checked) {
                textBox9.Text = "0x" + FormatHex(res.ToString("X"), (byte)(_Size / 4));
                textBox10.Text = "0x" + FormatSHex((~res).ToString("X"));
            } else {
                textBox9.Text = a;
                textBox10.Text = b;
            }
        }


        public string uint2hex(uint temp) {
            return temp.ToString("X");
        }

        string a = " ";
        string b = " ";

        private bool convert(uint res) {
            try {
                if (_Size == 8) {
                    byte temp = Convert.ToByte(res);
                    a = Convert.ToString(temp);
                    b = Convert.ToString(~temp);
                } else if (_Size == 16) {
                    UInt16 temp = Convert.ToUInt16(res);
                    a = Convert.ToString(temp);
                    b = Convert.ToString(~temp);
                } else {
                    Int32 temp = Convert.ToInt32(res);
                    a = Convert.ToString(temp);
                    b = Convert.ToString(~temp);
                }
                return true;
            } catch (Exception) {
                return false;
            }
        }

        private string FormatHex(string temp, byte size) {
            while (temp.Length < size)
                temp = "0" + temp;
            size -= 2;
            while (size > 0) {
                temp = temp.Insert(size, " ");
                size -= 2;
            }
            return temp;
        }

        private string FormatSHex(string temp) {
            byte size = (byte)(_Size / 4);
            temp = temp.Substring(temp.Length - size);
            size -= 2;
            while (size > 0) {
                temp = temp.Insert(size, " ");
                size -= 2;
            }
            return temp;
        }


        private void SevenSegment_Load(object sender, EventArgs e) {
            DisplayResult();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            DisplayResult();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            DisplayResult();
        }

        private bool OverUseCheck() {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    if (j != i)
                        if (ports[i] == ports[j])
                            return true;
            return false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) {
            _Size = 8;
            DisplayResult();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) {
            _Size = 16;
            DisplayResult();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e) {
            _Size = 32;
            DisplayResult();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox1 f = new AboutBox1();
            f.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            String Data = "";
            for (int i = 0; i < 8; i++)
                Data += ports[i] + "\n";
            if (radioButton1.Checked)
                Data += "0\n";
            else
                Data += "1\n";

            if (radioButton3.Checked)
                Data += "0\n";
            else if (radioButton4.Checked)
                Data += "1\n";
            else
                Data += "2\n";

            SaveFileDialog d = new SaveFileDialog();
            d.DefaultExt = "txt";
            d.FileName = "7SegmentSetings";
            d.Filter = "7 Segment Files (*.7seg)|*.7seg";

            if (d.ShowDialog() == DialogResult.OK) {
                StreamWriter wr = new StreamWriter(d.FileName);
                wr.Write(Data);
                wr.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "7 Segment Files (*.7seg)|*.7seg";

            if (d.ShowDialog() == DialogResult.OK) {
                StreamReader wr = new StreamReader(d.FileName);
                for (int i = 0; i < 8; i++)
                    ports[i] = Convert.ToUInt32(wr.ReadLine());
                if (wr.ReadLine() == "0")
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;
                String temp = wr.ReadLine();
                if (temp == "0")
                    radioButton3.Checked = true;
                else if (temp == "1")
                    radioButton4.Checked = true;
                else
                    radioButton5.Checked = true;
                textBox1.Text = Math.Log(ports[0], 2) + "";
                textBox2.Text = Math.Log(ports[1], 2) + "";
                textBox3.Text = Math.Log(ports[2], 2) + "";
                textBox4.Text = Math.Log(ports[3], 2) + "";
                textBox5.Text = Math.Log(ports[4], 2) + "";
                textBox6.Text = Math.Log(ports[5], 2) + "";
                textBox7.Text = Math.Log(ports[6], 2) + "";
                textBox8.Text = Math.Log(ports[7], 2) + "";

                wr.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e) {
            String[] DataCA = new String[16];
            String[] DataCC = new String[16];

            bool[] tempbtn = btns;
            for (byte i = 0; i < 8; i++)
                tempbtn[i] = !tempbtn[i];


            btns = new bool[] { true, true, true, true, true, true, true, true };
            Clicks();
            //0
            btns = new bool[] { false, false, false, false, false, false, true, true };
            Clicks();
            DataCA[0] = textBox10.Text;
            DataCC[0] = textBox9.Text;
            //1
            btns = new bool[] { true, false, false, true, true, true, true, true };
            Clicks();
            DataCC[1] = textBox9.Text;
            DataCA[1] = textBox10.Text;
            //2
            btns = new bool[] { false, false, true, false, false, true, false, true };
            Clicks();
            DataCC[2] = textBox9.Text;
            DataCA[2] = textBox10.Text;
            //3
            btns = new bool[] { false, false, false, false, true, true, false, true };
            Clicks();
            DataCC[3] = textBox9.Text;
            DataCA[3] = textBox10.Text;
            //4
            btns = new bool[] { true, false, false, true, true, false, false, true };
            Clicks();
            DataCC[4] = textBox9.Text;
            DataCA[4] = textBox10.Text;
            //5
            btns = new bool[] { false, true, false, false, true, false, false, true };
            Clicks();
            DataCC[5] = textBox9.Text;
            DataCA[5] = textBox10.Text;
            //6
            btns = new bool[] { false, true, false, false, false, false, false, true };
            Clicks();
            DataCC[6] = textBox9.Text;
            DataCA[6] = textBox10.Text;
            //7
            btns = new bool[] { false, false, false, true, true, true, true, true };
            Clicks();
            DataCC[7] = textBox9.Text;
            DataCA[7] = textBox10.Text;
            //8
            btns = new bool[] { false, false, false, false, false, false, false, true };
            Clicks();
            DataCC[8] = textBox9.Text;
            DataCA[8] = textBox10.Text;
            //9
            btns = new bool[] { false, false, false, false, true, false, false, true };
            Clicks();
            DataCC[9] = textBox9.Text;
            DataCA[9] = textBox10.Text;
            //A
            btns = new bool[] { false, false, false, true, false, false, false, true };
            Clicks();
            DataCC[10] = textBox9.Text;
            DataCA[10] = textBox10.Text;
            //b
            btns = new bool[] { true, true, false, false, false, false, false, true };
            Clicks();
            DataCC[11] = textBox9.Text;
            DataCA[11] = textBox10.Text;
            //C
            btns = new bool[] { false, true, true, false, false, false, true, true };
            Clicks();
            DataCC[12] = textBox9.Text;
            DataCA[12] = textBox10.Text;
            //d
            btns = new bool[] { true, false, false, false, false, true, false, true };
            Clicks();
            DataCC[13] = textBox9.Text;
            DataCA[13] = textBox10.Text;
            //E
            btns = new bool[] { false, true, true, false, false, false, false, true };
            Clicks();
            DataCC[14] = textBox9.Text;
            DataCA[14] = textBox10.Text;
            //F
            btns = new bool[] { false, true, true, true, false, false, false, true };
            Clicks();
            DataCC[15] = textBox9.Text;
            DataCA[15] = textBox10.Text;

            btns = tempbtn;
            Clicks();
            FontTable d = new FontTable();
            d.SetText(DataCA, DataCC);
            d.ShowDialog();
        }

        private void Clicks() {
            button1_Click(null, null);
            button2_Click(null, null);
            button3_Click(null, null);
            button4_Click(null, null);
            button5_Click(null, null);
            button6_Click(null, null);
            button7_Click(null, null);
            button8_Click(null, null);
        }


    }
}
