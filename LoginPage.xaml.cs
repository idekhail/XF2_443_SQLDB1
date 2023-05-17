using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XF2_443_SQLDB1
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Close.Clicked += (s, e) => Environment.Exit(0);
            Create.Clicked += (s, e) => Navigation.PushAsync(new CreatePage());
        }
        private async void Login_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Username.Text))
            {
                var user = await App.UserSQLite.LoginAsync(Username.Text, Password.Text);
                if (user != null)
                {
                    
                        await Navigation.PushAsync(new ShowPage(user));
                   
                }
                else
                    await DisplayAlert("Error", "Username is error", "Ok");
            }
            else
                await DisplayAlert("Error", "Username is empty", "Ok");
        }

       
        protected override void OnAppearing()
        {
            base.OnAppearing();
            //Username.Focus = true;           

        }
    }
}
