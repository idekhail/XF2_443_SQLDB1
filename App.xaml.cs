using System;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF2_443_SQLDB1
{
    public partial class App : Application
    {

        static UsersOperations db;

        // Create the database connection as a singleton.
        public static UsersOperations UserSQLite
        {
            get
            {
                if (db == null)
                {
                    db = new UsersOperations(Path.Combine(Environment.GetFolderPath(
                        Environment.SpecialFolder.LocalApplicationData), "XF2DB1.db3"));
                }
                return db;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage =new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
