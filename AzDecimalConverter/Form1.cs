using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AzDecimalConverter
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetTicks();

        }

        private void GetTicks()
        {
            textBox1.Text = DateTime.Now.Ticks.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetTicks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long d = Convert.ToInt64(textBox1.Text);
            textBox2.Text = d.ToAzDecimal(checkBox1.Checked);
        }
    }
}
