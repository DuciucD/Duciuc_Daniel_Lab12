using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Duciuc_Daniel_Lab12_Mobile.Data;

namespace Duciuc_Daniel_Lab12_Mobile
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            //InitializeComponent();

            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
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
