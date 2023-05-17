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
    public partial class UpdatePage : ContentPage
    {
        Users user;
        public UpdatePage(Users user)
        {
            InitializeComponent();
            this.user = user;
            Cancel.Clicked += (s, e) => Navigation.PopAsync();

            UId.Text = this.user.Id.ToString();
            Username.Text = this.user.Username;
            Password.Text = this.user.Password;            
        }
        private async void Update_Clicked(object sender, EventArgs e)
        {
            this.user.Username = Username.Text;
            this.user.Password = Password.Text;
            
            await App.UserSQLite.SaveUserAsync(this.user);
            await Navigation.PopToRootAsync();
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            await App.UserSQLite.DeleteUserAsync(this.user);
            await Navigation.PopToRootAsync();
        }
    }
}