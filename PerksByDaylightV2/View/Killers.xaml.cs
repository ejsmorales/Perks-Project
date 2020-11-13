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
    public partial class Killers : ContentPage
    {
        public ObservableCollection<MenuClass> Items { get; set; }

        public Killers()
        {
            InitializeComponent();

            Items = new ObservableCollection<MenuClass>();
            {
                Items.Add(new MenuClass { CharacterName = "All", CharacterPicture = "killerlogo.png" });
                Items.Add(new MenuClass { CharacterName = "The Blight", CharacterPicture = "blight.png" });
                Items.Add(new MenuClass { CharacterName = "The Cannibal", CharacterPicture = "cannibal.png" });
                Items.Add(new MenuClass { CharacterName = "The Clown", CharacterPicture = "clown.png" });
                Items.Add(new MenuClass { CharacterName = "The Deathslinger", CharacterPicture = "deathslinger.png" });
                Items.Add(new MenuClass { CharacterName = "The Demogorgon", CharacterPicture = "demogorgon.png" });
                Items.Add(new MenuClass { CharacterName = "The Doctor", CharacterPicture = "doctor.png" });
                Items.Add(new MenuClass { CharacterName = "The Executioner", CharacterPicture = "executioner.png" });
                Items.Add(new MenuClass { CharacterName = "The Ghostface", CharacterPicture = "ghostface.png" });
                Items.Add(new MenuClass { CharacterName = "The Hag", CharacterPicture = "hag.png" });
                Items.Add(new MenuClass { CharacterName = "The Hillbilly", CharacterPicture = "hillbilly.png" });
                Items.Add(new MenuClass { CharacterName = "The Huntress", CharacterPicture = "huntress.png" });
                Items.Add(new MenuClass { CharacterName = "The Legion", CharacterPicture = "legion.png" });
                Items.Add(new MenuClass { CharacterName = "The Nightmare", CharacterPicture = "nightmare.png" });
                Items.Add(new MenuClass { CharacterName = "The Nurse", CharacterPicture = "nurse.png" });
                Items.Add(new MenuClass { CharacterName = "The Oni", CharacterPicture = "oni.png" });
                Items.Add(new MenuClass { CharacterName = "The Pig", CharacterPicture = "pig.png" });
                Items.Add(new MenuClass { CharacterName = "The Plague", CharacterPicture = "plague.png" });
                Items.Add(new MenuClass { CharacterName = "The Shape", CharacterPicture = "shape.png" });
                Items.Add(new MenuClass { CharacterName = "The Spirit", CharacterPicture = "spirit.png" });
                Items.Add(new MenuClass { CharacterName = "The Trapper", CharacterPicture = "trapper.png" });
                Items.Add(new MenuClass { CharacterName = "The Wraith", CharacterPicture = "wraith.png" });
            };
            MyListView.ItemsSource = Items;
        }

        private async void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var message = (MenuClass)e.SelectedItem;
            if (e.SelectedItem == null)
                return;
            string role = "Killer";
            //await DisplayAlert("ok",message.CharacterName.ToString(),"ok");
            await Navigation.PushAsync(new PerkInformationPage(message.CharacterName.ToString(), role, message.CharacterPicture.ToString()), true);
            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }

}