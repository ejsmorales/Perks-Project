using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PerksByDaylightV2
{
    public partial class App : Application
    {
        public static string DbPath;

        public App(string dbPath)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzM5MzM3QDMxMzgyZTMzMmUzMG5ta0xCRTh1a2ZUZE1XN2RidmRXYjVCUWk4ZUYwODZmNG95TldlOVF2ODg9");

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            //MainPage = new AnimationNavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#2b2b2b")

            };

            DbPath = dbPath;
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
