using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo
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

        private void btCong_Click(object sender, EventArgs e)
        {
// thang son hach dich
            double a = double.Parse(TxtA.text);
            double b = double.Parse(TxtB.text);
            double c = a + b;
            txtKQ.Text = c.ToString();
        }

       
    }
}
