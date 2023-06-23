using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zad6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Three :ContentPage
    {
        public Three (string login, string pass,double sl1, double sl2, double sl3, double sl4)
        {
            InitializeComponent();
            LoginTxt.Text = $"Ваш логин: {login}";
            PassTxt.Text = $"Ваш пароль: {pass}";
            Slider1Txt.Text = $"Значение Ползунка 1: {sl1}";
            Slider2Txt.Text = $"Значение Ползунка 2: {sl2}";
            Slider3Txt.Text = $"Значение Ползунка 3: {sl3}";
            Slider4Txt.Text = $"Значение Ползунка 4: {sl4}";
        }
    }
}