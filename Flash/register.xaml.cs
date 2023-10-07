using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Flash
{
    public partial class register : ContentPage
    {
        
        public register()
        {
            InitializeComponent();
        }

        private async void Registracija(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(unosUsername.Text) &&
                !string.IsNullOrWhiteSpace(unosBrojTelefona.Text) &&
                !string.IsNullOrWhiteSpace(unosSifre.Text) && (unosSifre.Text != unosPSifre.Text))
            {
                await DisplayAlert("Upozorenje", "Niste unijeli tačnu šifru.", "Nazad");
            }
            else if(!string.IsNullOrWhiteSpace(unosUsername.Text) && 
                !string.IsNullOrWhiteSpace(unosBrojTelefona.Text) &&
                !string.IsNullOrWhiteSpace(unosSifre.Text) && (unosSifre.Text==unosPSifre.Text))
            {
                await App.BazaPodataka.SaveKorisnik(new Korisnici
                {
                    korisnickoIme=unosUsername.Text,
                    brojTelefona=unosBrojTelefona.Text,
                    Sifra = unosSifre.Text
                });
                unosBrojTelefona.Text = unosSifre.Text = unosUsername.Text = unosPSifre.Text = string.Empty;
                await DisplayAlert("", "Uspješno ste se registrovali. Molimo da se sada prijavite.", "Nazad");
                await Navigation.PopToRootAsync();
            }
            else
            {
                await DisplayAlert("Upozorenje", "Molimo Vas unesite sve podatke u naznačena polja.", "Nazad");
            }

        }
    }
}