using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnZarAt_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            string message= Play(out number1,out number2);
            MessageBox.Show(message);
            lblZar1.Text = number1.ToString();
            lblZar2.Text = number2.ToString();

        }

        private string Play(out int number1, out int number2)
        {
            number1 = random.Next(1, 7);
            number2 = random.Next(1, 7);
            string message;
            if (number1 == number2)
            {
                message = "Kazandiniz";
            }
            else
            {
                 message = "Kaybettiniz";
            }

            return message;

        }
    }
}
