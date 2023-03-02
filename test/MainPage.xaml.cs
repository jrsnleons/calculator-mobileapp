using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private decimal firstNumber;
        private string operatorN;
        private bool isOperatorClicked;


        private void BtnAct(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (BtnRes.Text == "0" || isOperatorClicked)
            {
                isOperatorClicked = false;
                BtnRes.Text = button.Text;
            }
            else
            {
                BtnRes.Text += button.Text;
            }


        }

        private void BtnClr(object sender, EventArgs e)
        {
            BtnRes.Text = "0";
        }

        private void BtnDel(object sender, EventArgs e)
        {
            string number = BtnRes.Text;
            if (number != "0")
            {
                number = number.Remove(number.Length - 1, 1);
                if (string.IsNullOrEmpty(number))
                {
                    BtnRes.Text = "0";
                }
                else
                {
                    BtnRes.Text = number;
                }
            }
        }

        private void BtnOps(object sender, EventArgs e)
        {
            var button = sender as Button;
            isOperatorClicked = true;
            operatorN = button.Text;
            firstNumber = Convert.ToDecimal(BtnRes.Text);

        }

        private void BtnEqual_Clicked(object sender, EventArgs e)
        {
            decimal secondNumber = Convert.ToDecimal(BtnRes.Text);
            decimal finalResult = Calculate(firstNumber, secondNumber);
            BtnRes.Text = finalResult.ToString();
        }

        public decimal Calculate(decimal firstNumber, decimal secondNumber)
        {
            decimal result = 0;
            if (operatorN == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (operatorN == "-")
            {
                result = secondNumber - firstNumber;

            }
            else if (operatorN == "x")
            {
                result = (firstNumber * secondNumber);

            }
            else if (operatorN == "/")
            {

                result = firstNumber / secondNumber;
            }
            return result;
        }


    }


}
