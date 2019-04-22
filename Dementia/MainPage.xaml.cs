using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Dementia
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "回登入頁面");
            buttonLogin.Clicked += ButtonLogin_Clicked;
        }

        private async void ButtonLogin_Clicked(object sender, EventArgs e)
        {
            // 換頁
            await Navigation.PushAsync(new LoginPage(),true);
        }
    }
}
