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
    public partial class LoginPage :CarouselPage
    {
        public LoginPage ()
        {
            InitializeComponent();
        }
        //Метод проверяющий вводные данные и переходящий на другой экран
        private async void InputButton_Clicked (object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(login.Text) || string.IsNullOrEmpty(pass.Text))
            {
                DisplayAlert("Внимание", "Заполните логин и пароль", "OK");
                return;
            }

            await Navigation.PushModalAsync(new MainPage(login.Text, pass.Text));
        }
    }
}