using PerksByDaylightV2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PerksByDaylightV2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Survivors : ContentPage
    {
        public ObservableCollection<Models.MenuClass> Items { get; set; }

        public Survivors()
        {
            InitializeComponent();

            Items = new ObservableCollection<Models.MenuClass>();
            {
                Items.Add(new Models.MenuClass { CharacterName = "All", CharacterPicture = "SurvivorLogo.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Ace Visconti", CharacterPicture = "ace.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Adam Francis", CharacterPicture = "adam.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Ash Williams", CharacterPicture = "ash.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Bill Overbeck", CharacterPicture = "bill.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Cheryl Mason", CharacterPicture = "cheryl.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Claudette Morel", CharacterPicture = "claudette.png" });
                Items.Add(new Models.MenuClass { CharacterName = "David King", CharacterPicture = "david.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Detective David Tapp", CharacterPicture = "tapp.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Dwight Fairfield", CharacterPicture = "dwight.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Felix Richter", CharacterPicture = "felix.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Feng Min", CharacterPicture = "feng.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Jake Park", CharacterPicture = "jake.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Jane Romero", CharacterPicture = "jane.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Jeff Johansen", CharacterPicture = "jeff.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Kate Denson", CharacterPicture = "kate.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Laurie Strode", CharacterPicture = "laurie.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Meg Thomas", CharacterPicture = "meg.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Nancy Wheeler", CharacterPicture = "nancy.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Nea Karlsson", CharacterPicture = "nea.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Quentin Smith", CharacterPicture = "quentin.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Steve Harrington", CharacterPicture = "steve.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Yui Kimura", CharacterPicture = "yui.png" });
                Items.Add(new Models.MenuClass { CharacterName = "Zarina Kassir", CharacterPicture = "zarina.png" });
            };
            MyListView.ItemsSource = Items;
        }



        private async void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var message = (MenuClass)e.SelectedItem;
            if (e.SelectedItem == null)
                return;
            string role = "Survivor";
            //await DisplayAlert("ok",message.CharacterName.ToString(),"ok");
            await Navigation.PushAsync(new PerkInformationPage(message.CharacterName.ToString(), role, message.CharacterPicture.ToString()), true);
            //Deselect Item
            ((ListView)sender).SelectedItem = null;

        }
    }
}