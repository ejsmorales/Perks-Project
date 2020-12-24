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
    public partial class PerkType : ContentPage
    {
        public ObservableCollection<MenuClass> SurvivorTypeList { get; set; }

        public ObservableCollection<MenuClass> KillerTypeList { get; set; }

        public PerkType()
        {
            InitializeComponent();

            SurvivorTypeList = new ObservableCollection<MenuClass>();

            SurvivorTypeList.Add(new MenuClass { PerkType = "Generators", CharacterPicture = "meg.png" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Items", CharacterPicture = "ace.png" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Aura Reading", CharacterPicture = "ace.png" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Exhaustion", CharacterPicture = "ace.png" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Chase", CharacterPicture = "ACE.PNG" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Totems", CharacterPicture = "ACE.PNG" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Movement Speed", CharacterPicture = "ACE.PNG" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Unhooking", CharacterPicture = "ACE.PNG" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Healing", CharacterPicture = "ACE.PNG" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Bloodpoints", CharacterPicture = "ACE.PNG" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Lockers", CharacterPicture = "ACE.PNG" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Altruism", CharacterPicture = "ACE.PNG" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Obsession", CharacterPicture = "ACE.PNG" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Stealth", CharacterPicture = "ACE.PNG" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Recovery", CharacterPicture = "ACE.PNG" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Teamwork", CharacterPicture = "ACE.PNG" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Distraction", CharacterPicture = "ACE.PNG" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Stun", CharacterPicture = "ACE.PNG" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Tracking", CharacterPicture = "ACE.PNG" });
            SurvivorTypeList.Add(new MenuClass { PerkType = "Pallets", CharacterPicture = "ACE.PNG" });


            //SurvivorTypeList = new ObservableCollection<MenuClass>(SurvivorTypeList.OrderBy(i => i));
            SurvivorList.ItemsSource = SurvivorTypeList;

            KillerTypeList = new ObservableCollection<MenuClass>();

            KillerTypeList.Add(new MenuClass { PerkType = "Generators", Number = 7363750 });
            KillerTypeList.Add(new MenuClass { PerkType = "Items", Number = 7323250 });
            KillerTypeList.Add(new MenuClass { PerkType = "Aura Reading", Number = 7239121 });
            KillerTypeList.Add(new MenuClass { PerkType = "Chase", Number = 2329823 });
            KillerTypeList.Add(new MenuClass { PerkType = "Tracking", Number = 8013481 });
            KillerTypeList.Add(new MenuClass { PerkType = "Movement Speed", Number = 7872329 });
            KillerTypeList.Add(new MenuClass { PerkType = "Exposed", Number = 7317750 });
            KillerTypeList.Add(new MenuClass { PerkType = "Anti Healing", Number = 7363750 });
            KillerTypeList.Add(new MenuClass { PerkType = "Bloodpoints", Number = 7323250 });
            KillerTypeList.Add(new MenuClass { PerkType = "Buff", Number = 7239121 });
            KillerTypeList.Add(new MenuClass { PerkType = "Hooking", Number = 7239121 });
            KillerTypeList.Add(new MenuClass { PerkType = "Blindness/Oblivious", Number = 2329823 });
            KillerTypeList.Add(new MenuClass { PerkType = "Obsession", Number = 8013481 });
            KillerTypeList.Add(new MenuClass { PerkType = "Endgame", Number = 7872329 });
            KillerTypeList.Add(new MenuClass { PerkType = "Totems", Number = 7317750 });
            KillerTypeList.Add(new MenuClass { PerkType = "Lockers", Number = 7317750 });
            KillerTypeList.Add(new MenuClass { PerkType = "Basement", Number = 7317750 });
            KillerTypeList.Add(new MenuClass { PerkType = "Skill Checks", Number = 7317750 });
            KillerTypeList.Add(new MenuClass { PerkType = "Stun", Number = 7317750 });
            KillerTypeList.Add(new MenuClass { PerkType = "Terror Radius", Number = 7317750 });
            KillerTypeList.Add(new MenuClass { PerkType = "Cooldown Reduction", Number = 7317750 });
            KillerTypeList.Add(new MenuClass { PerkType = "Pallets", Number = 7317750 });

            //SurvivorTypeList = new ObservableCollection<MenuClass>(SurvivorTypeList.OrderBy(i => i));
            KillerList.ItemsSource = KillerTypeList;
        }

        private async void SurvivorList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var message = (MenuClass)e.Item;
            if (e.Item == null)
                return;
            string role = "Survivor";
            //await DisplayAlert("ok",message.PerkType.ToString(),"ok");
            await Navigation.PushAsync(new PerkTypeInformationPage(message.PerkType.ToString(), role),true);
            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        private async void KillerList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var message = (MenuClass)e.Item;
            if (e.Item == null)
                return;
            string role = "Killer";
            await Navigation.PushAsync(new PerkTypeInformationPage(message.PerkType.ToString(), role),true);
            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}