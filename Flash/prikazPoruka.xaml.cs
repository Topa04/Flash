using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace Flash
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class prikazPoruka : ContentPage
    {
        public prikazPoruka()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            lista.ItemsSource = await App.BazaPodataka.GetPoruke();
        }

        private void lista_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var korisnik = e.Item as Poruke;
            Navigation.PushAsync(new Poruka(korisnik));
        }

        private async void Brisanje(object sender, EventArgs e)
        {
            var item = sender as ImageButton;
            var poruka = item.CommandParameter as Poruke;
            var rezultat = await DisplayAlert("Izbriši", $"Da li želite izbrisati {poruka.naslovPoruke} od korisnika {poruka.korisnickoImeIPrezime}?", "Yes", "No");
            if (rezultat)
            {
                await App.BazaPodataka.IzbrisiPoruku(poruka);
                lista.ItemsSource = await App.BazaPodataka.GetPoruke();
            }
        }
    }
}