using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt1_gorsel_4Ara_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button1.Visible = true;
            }
            if (radioButton2.Checked == true)
            {
                button1.Visible = false;
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                button2.Visible = true;
            }
            if (radioButton4.Checked == true)
            {
                button2.Visible = false;
            }
        }
    }
}
