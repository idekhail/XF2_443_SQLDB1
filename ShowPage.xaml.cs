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
    public partial class ShowPage : ContentPage
    {
        Users user;
        public ShowPage(Users user)
        {
            
            InitializeComponent();
            this.user = user;
            Logout.Clicked += (s, e) => Navigation.PopAsync();
            Username.Text = "Welcome: "+ user.Username;
            ShowMe.Text = user.Id + "    " + user.Username + "    " + user.Password + "\n";
        }

        private void Update_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UpdatePage(user));
            
        }
    }
}