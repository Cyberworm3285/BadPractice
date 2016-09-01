using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nim_schlecht_und_scheisse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add(3);
        }

        private void add(int a)
        {
            label2.Text = "";
            if (label1.Text.Length + a >= 11) loose();
            else label1.Text += new string('O',a);
        }

        private void loose()
        {
            label1.Text = "";
            label2.Text = "du hast verloren";
        }

    }
}
