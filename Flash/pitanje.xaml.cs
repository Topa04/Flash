using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Flash
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pitanje : ContentPage
    {
        public pitanje()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(EntryIme.Text) &&
                !string.IsNullOrWhiteSpace(EntryEmail.Text) &&
                !string.IsNullOrWhiteSpace(EntryNaslov.Text) &&
                !string.IsNullOrWhiteSpace(EntryPoruka.Text))
            {
                await App.BazaPodataka.SpasiPoruku(new Poruke
                {
                    korisnickoImeIPrezime = EntryIme.Text,
                    Email = EntryEmail.Text,
                    naslovPoruke = EntryNaslov.Text,
                    tekstPoruke = EntryPoruka.Text,
                });
                EntryIme.Text = EntryEmail.Text = EntryNaslov.Text = EntryPoruka.Text= string.Empty;
                await DisplayAlert("", "Vaša poruka je uspješno poslana.", "Nazad");
                await Navigation.PopAsync();

            }
            else
            {
                await DisplayAlert("Upozorenje", "Molimo Vas unesite sve podatke u naznačena polja.", "Nazad");
            }
        }
    }
}