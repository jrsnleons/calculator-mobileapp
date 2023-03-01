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


        private void BtnAct (object sender, EventArgs e)
        {
           var button=sender as Button;
        if (BtnRes.Text == "0")
            {
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
            if(number != "0") 
            { 
                number = number.Remove(number.Length-1,1);
                if (string.IsNullOrEmpty(number))
                {
                    BtnRes.Text="0";
                }
                else 
                {
                    BtnRes.Text = number;
                }
            }
        }
    }


}
