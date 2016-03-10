using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7Segment_Calculator {
    public partial class FontTable : Form {
        public FontTable() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        public void SetText(String[] DataCA, String[] DataCC) {
            textBox1.Text = DataCC[0];
            textBox2.Text = DataCC[1];
            textBox3.Text = DataCC[2];
            textBox4.Text = DataCC[3];
            textBox5.Text = DataCC[4];
            textBox6.Text = DataCC[5];
            textBox7.Text = DataCC[6];
            textBox8.Text = DataCC[7];
            textBox9.Text = DataCC[8];
            textBox10.Text = DataCC[9];
            textBox11.Text = DataCC[10];
            textBox12.Text = DataCC[11];
            textBox13.Text = DataCC[12];
            textBox14.Text = DataCC[13];
            textBox15.Text = DataCC[14];
            textBox16.Text = DataCC[15];

            textBox17.Text = DataCA[0];
            textBox18.Text = DataCA[1];
            textBox19.Text = DataCA[2];
            textBox20.Text = DataCA[3];
            textBox21.Text = DataCA[4];
            textBox22.Text = DataCA[5];
            textBox23.Text = DataCA[6];
            textBox24.Text = DataCA[7];
            textBox25.Text = DataCA[8];
            textBox26.Text = DataCA[9];
            textBox27.Text = DataCA[10];
            textBox28.Text = DataCA[11];
            textBox29.Text = DataCA[12];
            textBox30.Text = DataCA[13];
            textBox31.Text = DataCA[14];
            textBox32.Text = DataCA[15];

        }


    }
}
