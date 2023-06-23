using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace zad6
{
    public partial class MainPage :ContentPage
    {
        static string logint, passt;
        static double slvalue1, slvalue2, slvalue3, slvalue4;
        public MainPage (string login,string pass)
        {
            InitializeComponent();
            logint = login;
            passt = pass;
        }
        private void Switch_Toggled (object sender, ToggledEventArgs e)
        {
            if (swich1.IsToggled == true)
            {
                OnOff1.Text = "On";
                OnOff1.Margin = new Thickness(0, 8, 10, 0);
            } else
            {
                OnOff1.Text = "Off";
                OnOff1.Margin = new Thickness(0, 8, 4, 0);
            }
        }

        private void slider1_ValueChanged (object sender, ValueChangedEventArgs e)
        {
            slvalue1 = slider1.Value;
            slvalue2 = slider2.Value;
            slvalue3 = slider3.Value;
            slvalue4 = slider4.Value;
        }

        private void slider2_ValueChanged (object sender, ValueChangedEventArgs e)
        {

        }

        private void swich2_Toggled (object sender, ToggledEventArgs e)
        {
            if (swich2.IsToggled == true)
            {
                OnOff2.Text = "On";
                OnOff2.Margin = new Thickness(0, 8, 3, 0);
            } else
            {
                OnOff2.Text = "Off";
                OnOff2.Margin = new Thickness(0, 8, 0, 0);
            }
        }

        private void Switch_Toggled_1 (object sender, ToggledEventArgs e)
        {
            if (swich3.IsToggled == true)
            {
                OnOff3.Text = "✓";
            } else
                OnOff3.Text = "✕";
        }

        private void swich4_Toggled (object sender, ToggledEventArgs e)
        {
            if (swich4.IsToggled == true)
            {
                OnOff4.Text = "✓";
            } else
                OnOff4.Text = "✕";
        }

        private void Button_Clicked (object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Three(logint,passt,slvalue1, slvalue2, slvalue3, slvalue4));
        }
    }
}
