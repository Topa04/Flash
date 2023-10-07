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
    public partial class login : ContentPage
    {
        string ime="";
        string sifra="";
        public login()
        {
            InitializeComponent();
        }
        async void Prijava(object sender, EventArgs e)
        {
            ime = unosUserName.Text;
            sifra = unosSifre.Text;
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "korisnici.db3");
            var baza = new SQLiteConnection(path);
            var provjera= baza.Table<Korisnici>().Where(u=>u.korisnickoIme.Equals(ime) && u.Sifra.Equals(sifra)).FirstOrDefault();
            if(provjera !=null)
            {
                await Navigation.PushAsync(new Homepage());
            }
            else if (ime=="admin" && sifra == "123")
            {
                await Navigation.PushAsync (new admin());
            }
            else
            {
                await DisplayAlert("Netačni podaci", "Greška, pogrešno uneseno korisničko ime ili sifra!", "Pokušaj ponovo");
            }

        }

         async void Button_Clicked1(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new register());
        }
    }
}