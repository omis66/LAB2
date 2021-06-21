using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            double waga = double.Parse(textBox1.Text);
            double standardowa = waga - 100;
            double idealnaK = standardowa * 0.85;
            double idealnaM = standardowa * 0.90;

            if (rbtnKobieta.Checked)
            {

                if (checkBoxStandard.Checked)
                {
                    label3.Text = (standardowa).ToString();
                }
                else if (checkBoxIdealna.Checked)
                {
                    label3.Text = (idealnaK).ToString();
                }
                else
                {
                    label3.Text = "Podaj opcje wagi!!";
                }

            }
                

            if (rbtnMezczyzna.Checked)
            {

                if (checkBoxStandard.Checked)
                {
                   label3.Text = (standardowa).ToString();
                }
                else if (checkBoxIdealna.Checked)
                {
                   label3.Text = (idealnaM).ToString();
                }
                else
                {
                   label3.Text = "Podaj opcje wagi!!";
                }

            }
                



        }
    }
}
