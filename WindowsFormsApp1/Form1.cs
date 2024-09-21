using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }


        private void dell(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void dellAll(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf("=") != -1)
                textBox1.Text = null;
            textBox1.AppendText("3");
        }

        private void buttonClick4(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf("=") != -1)
                textBox1.Text = null;
            textBox1.AppendText("4");
        }
        private void buttonClick5(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf("=") != -1)
                textBox1.Text = null;
            textBox1.AppendText("5");
        }
        private void buttonClick6(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf("=") != -1)
                textBox1.Text = null;
            textBox1.AppendText("6");
        }
        private void buttonClick7(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf("=") != -1)
                textBox1.Text = null;
            textBox1.AppendText("7");
        }
        private void buttonClick8(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf("=") != -1)
                textBox1.Text = null;
            textBox1.AppendText("8");
        }
        private void buttonClick9(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf("=") != -1)
                textBox1.Text = null;
            textBox1.AppendText("9");
        }
        private void buttonClick0(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf("=") != -1)
                textBox1.Text = null;
            textBox1.AppendText("0");
        }
        private void buttonClickPlus(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox1.Text[textBox1.Text.Length - 1] != '-' && textBox1.Text[textBox1.Text.Length - 1] != '+' && textBox1.Text[textBox1.Text.Length - 1] != '*' && textBox1.Text[textBox1.Text.Length - 1] != '/')
                textBox1.AppendText("+");
        }
        private void buttonClickMinys(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf("=") != -1)
                textBox1.Text = null;
            if(textBox1.Text.Length != 0)
                if (textBox1.Text[textBox1.Text.Length - 1] != '-' && textBox1.Text[textBox1.Text.Length - 1] != '+' && textBox1.Text[textBox1.Text.Length - 1] != '*' && textBox1.Text[textBox1.Text.Length - 1] != '/')
                    textBox1.AppendText("-");
            if (textBox1.Text.Length == 0) textBox1.AppendText ("-");
        }
        private void buttonClickYm(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0 && textBox1.Text[textBox1.Text.Length - 1] != '-' && textBox1.Text[textBox1.Text.Length - 1] != '+' && textBox1.Text[textBox1.Text.Length - 1] != '*' && textBox1.Text[textBox1.Text.Length - 1] != '/')
                textBox1.AppendText("*");
        }
        private void buttonClickdelenie(object sender, EventArgs e)
        {
            if(textBox1.Text.Length != 0 && textBox1.Text[textBox1.Text.Length - 1] != '-' && textBox1.Text[textBox1.Text.Length - 1] != '+' && textBox1.Text[textBox1.Text.Length - 1] != '*' && textBox1.Text[textBox1.Text.Length - 1] != '/')
                textBox1.AppendText("/");
        }
        private void buttonClickUtog(object sender, EventArgs e)
        {
            try
            {
                string input = textBox1.Text;
                var result = new DataTable().Compute(input, null);
                textBox1.Text = result.ToString();
            }
            catch 
            {
                textBox1.Text = "Ошибка";
            }   
        }
    }
}
