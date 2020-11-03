using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.IO;
using System.Linq;

using SQLite;

namespace PerksByDaylightV2.Droid
{
    //[Activity(Label = "PerksByDaylightV2", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    [Activity(Label = "Perks By Daylight", Icon = "@mipmap/ic_launcher", Theme = "@style/MyTheme.Splash", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]


    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //This makes sure the splash screen doesnt show up on scrolling.
            SetTheme(Resource.Style.MainTheme);

            //Opening DB
            string dbName = "PerksByDaylight.db";
            string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "PerksByDaylight.db");

            // Check if your DB has already been extracted/exists
            if (!File.Exists(dbPath))
            //if DB doesnt exist or needs to be written, the code below will write the new one pasted on the assets
            {
                using (BinaryReader br = new BinaryReader(Android.App.Application.Context.Assets.Open(dbName)))
                {
                    using (BinaryWriter bw = new BinaryWriter(new FileStream(dbPath, FileMode.Create)))
                    {
                        byte[] buffer = new byte[2048];
                        int len = 0;
                        while ((len = br.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            bw.Write(buffer, 0, len);
                        }
                    }
                }
            }
            else
            //at this point the SQlitedb is present, it will check if the version in the present one is the same as the new one, this is hardcoded for now
            {
                using (SQLiteConnection connection = new SQLiteConnection(dbPath))
                {
                    connection.CreateTable<Models.PerksByDaylight>();
                    var myVersion = (from Perks in connection.Table<Models.PerksByDaylight>() where Perks.ID == 0 select Perks.Version).FirstOrDefault();
                    //this If statement checks the version in the device is the same as the included db, if they arent it will overwrite the SQLite DB
                    if (myVersion != 2)

                    {
                        using (BinaryReader br = new BinaryReader(Android.App.Application.Context.Assets.Open(dbName)))
                        {
                            using (BinaryWriter bw = new BinaryWriter(new FileStream(dbPath, FileMode.Create)))
                            {
                                byte[] buffer = new byte[2048];
                                int len = 0;
                                while ((len = br.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    bw.Write(buffer, 0, len);
                                }
                            }
                        }
                    }
                }
            }
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App(dbPath));
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}