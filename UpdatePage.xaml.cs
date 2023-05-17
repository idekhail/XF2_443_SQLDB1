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
        }
    }
}