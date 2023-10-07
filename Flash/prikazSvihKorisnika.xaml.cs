using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Flash
{
    public partial class prikazSvihKorisnika : ContentPage
    {
        public prikazSvihKorisnika()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            lista.ItemsSource = await App.BazaPodataka.GetKorisnici();
        }

        private async void Brisanje(object sender, EventArgs e)
        {
            var item = sender as ImageButton;
            var korisnik = item.CommandParameter as Korisnici;
            var rezultat = await DisplayAlert("Izbriši", $"Da li želite izbrisati {korisnik.korisnickoIme}?", "Yes", "No");
            if (rezultat)
            {
                await App.BazaPodataka.IzbrisiKorisnika(korisnik);
                lista.ItemsSource = await App.BazaPodataka.GetKorisnici();
            }
        }
    }
}
