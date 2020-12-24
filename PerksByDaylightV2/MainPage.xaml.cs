using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PerksByDaylightV2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void survivorListButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Survivors(), true);
        }

        private async void killerListButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Killers(), true);
        }

        private async void SynergiesButton_Clicked(object sender, EventArgs e)
        {
           
            await Navigation.PushAsync(new PerkType(), true);
        }
    }
}
