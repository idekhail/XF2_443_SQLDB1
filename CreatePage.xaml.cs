using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF2_443_SQLDB1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreatePage : ContentPage
    {
        public CreatePage()
        {
            InitializeComponent();
            Cancel.Clicked += (s, e) => Navigation.PopAsync();

        }

        private async void Create_Clicked(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(Username.Text)) && (!string.IsNullOrEmpty(Password.Text)))
            {
                var user = new Users()
                {
                    Username = Username.Text,
                    Password = Password.Text,                    
                };
                await App.UserSQLite.SaveUserAsync(user);
                await DisplayAlert("Done", "Username is added", "Ok");
                await Navigation.PopAsync();
            }
            else
                await DisplayAlert("Error", "Username is empty Or Username is already existe", "Ok");
        }
    }
}