using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasitHesapMakinesi
{
    public partial class Form1 : Form
    {

        double number1=0;
        double number2=0;
        double[] numbers;
        double result;
        bool valid;

        public Form1()
        {
            InitializeComponent();
            SetButtons();
        }

        void SetButtons()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Click += new EventHandler(ButtonMethod);
                }
            }
        }

        private void ButtonMethod(object sender, EventArgs e)
        {
            numbers = GetData(out valid);

            if (valid)
            {
                Operate(numbers,((Button)sender).Text);
            }            
        }

        double[] GetData(out bool valid)
        {
            valid = false;

            if(number_text1.Text.Trim()=="" || number_text2.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen iki alana da giriş yapınız.");
            }
            else
            {
                try
                {
                    number1 = Convert.ToDouble(number_text1.Text);
                    number2 = Convert.ToDouble(number_text2.Text);
                    valid = true;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lütfen sayı haricinde bir giriş yapmayınız.");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Lütfen daha kısa bir sayı girişi yapınız");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            numbers =new double[] { number1, number2 };

            return numbers;
        }

        void Operate(double[] numbers, string operation)
        {

            switch (operation)
            {
                case ("+"):
                    result = numbers[0] + numbers[1];
                    break;
                case ("-"):
                    result = numbers[0] - numbers[1];
                    break;
                case ("*"):
                    result = numbers[0] * numbers[1];
                    break;
                case ("/"):
                    result = numbers[0] / numbers[1];
                    break;
                case ("%"):
                    result = numbers[0] % numbers[1];
                    break;
            }

            result_label.Text = result.ToString();
        }
    }
}
