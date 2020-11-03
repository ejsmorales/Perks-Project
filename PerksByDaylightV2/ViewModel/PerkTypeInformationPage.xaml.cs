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
    public partial class PerkTypeInformationPage : ContentPage
    {
        public PerkTypeInformationPage(string type, string role)
        {
            InitializeComponent();
            LoadPerks(type, role);
        }

        //public Task FindPerk(string type)
        public void LoadPerks(string type, string role)
        {

            using (SQLiteConnection connection = new SQLiteConnection(App.DbPath))
            {
                connection.CreateTable<Models.PerksByDaylight>();
                var MyList = connection.Table<Models.PerksByDaylight>().ToList();
                var myQuery = (from Perks in connection.Table<Models.PerksByDaylight>() where Perks.Type.Contains(type) && Perks.Role == role select Perks).ToList();

                myList.ItemsSource = myQuery;

            }
        }
    }
}