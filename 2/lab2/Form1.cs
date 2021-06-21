using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int newSize = 0;

            if (rbtnRed.Checked) {textBox1.ForeColor = Color.Red; }
            if (rbtnBlue.Checked) {textBox1.ForeColor = Color.Blue; }
            if (rbtnGreen.Checked) {textBox1.ForeColor = Color.Green; }
            
            if (rbtnMaly.Checked) 
            {
                newSize = 12;
                textBox1.Font = new System.Drawing.Font(textBox1.Font.Name, newSize); 
            }
            if (rbtnDuza.Checked) 
            {
                newSize = 15;
                textBox1.Font = new System.Drawing.Font(textBox1.Font.Name, newSize);
            }
            if (rbtnBDuza.Checked) 
            {
                newSize = 20;
                textBox1.Font = new System.Drawing.Font(textBox1.Font.Name, newSize); 
            }
            
            if((cbBold.Checked == true) || (cbItalic.Checked == true) || (cbLine.Checked == true))
            {
                if ((cbBold.Checked == true) && (cbItalic.Checked == true) && (cbLine.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, newSize, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if ((cbBold.Checked == true) && (cbItalic.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, newSize, FontStyle.Bold | FontStyle.Italic);
                }
                else if ((cbBold.Checked == true) && (cbLine.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, newSize, FontStyle.Bold | FontStyle.Underline);
                }
                else if ((cbItalic.Checked == true) && (cbLine.Checked == true))
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, newSize, FontStyle.Italic | FontStyle.Underline);
                }
                else if (cbBold.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, newSize, FontStyle.Bold);
                }
                else if (cbItalic.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, newSize, FontStyle.Italic);
                }
                else if (cbLine.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, newSize, FontStyle.Underline);
                }

            }

        }
    }
}
