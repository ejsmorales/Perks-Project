using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PerksByDaylightV2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PerkInformationPage : ContentPage
    {
        public PerkInformationPage(string name, string role)
        {
            InitializeComponent();
            LoadPerks(name, role);
        }

        public void LoadPerks(string name, string role)
        {

            using (SQLiteConnection connection = new SQLiteConnection(App.DbPath))
            {


                connection.CreateTable<Models.PerksByDaylight>();
                var MyList = connection.Table<Models.PerksByDaylight>().ToList();
                var myQuery = (from Perks in connection.Table<Models.PerksByDaylight>() where Perks.Character == name && Perks.Role == role select Perks).ToList();



                myList.ItemsSource = myQuery;

            }
        }
    }
}