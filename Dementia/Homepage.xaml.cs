using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Dementia
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "回到首頁");

        }

    }
}
