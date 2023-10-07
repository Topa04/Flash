using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Flash
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class paket : ContentPage
    {
        private int porukeOdg = 0;
        private int minuteOdg = 0;
        private int mbOdg = 0;
        private int cijenaOdg = 0;
        private Button Dugme;
        private int klikPoruke = 0;
        private int klikMinute = 0;
        private int klikMB = 0;
        private int klikCijena = 0;
        

        public paket()
        {
            InitializeComponent();
            Prihvati.IsEnabled = false;
        }

        private void MessagesButton_Clicked(object sender, EventArgs e)
        {
            Dugme = sender as Button;
            if (Dugme.BackgroundColor == Color.FromHex("#fe8402") && klikPoruke == 1)
            {
                Dugme.BackgroundColor = Color.FromHex("#290a28");
                Dugme.BorderColor = Color.FromHex("#fe8402");
                Dugme.TextColor = Color.White;
                klikPoruke--;
                porukeOdg -= Convert.ToInt32(Dugme.TabIndex);
            }
            else if (klikPoruke == 0)
            {
                porukeOdg = Convert.ToInt32(Dugme.TabIndex);
                Dugme.BackgroundColor = Color.FromHex("#fe8402");
                Dugme.BorderColor = Color.White;
                Dugme.TextColor = Color.White;
                klikPoruke++;
            }
            if (porukeOdg != 0 && minuteOdg != 0 && mbOdg != 0 && cijenaOdg != 0)
            {
                // Enable the submit button
                Prihvati.IsEnabled = true;
            }
            else
            {
                // Disable the submit button
                Prihvati.IsEnabled = false;
            }
        }

        private void MinutesButton_Clicked(object sender, EventArgs e)
        {
            Dugme = sender as Button;
            if (Dugme.BackgroundColor == Color.FromHex("#fe8402") && klikMinute == 1)
            {
                Dugme.BackgroundColor = Color.FromHex("#290a28");
                Dugme.BorderColor = Color.FromHex("#fe8402");
                Dugme.TextColor = Color.White;
                klikMinute--;
                minuteOdg -= Convert.ToInt32(Dugme.TabIndex);
            }
            else if (klikMinute == 0)
            {
                minuteOdg = Convert.ToInt32(Dugme.TabIndex);
                Dugme.BackgroundColor = Color.FromHex("#fe8402");
                Dugme.BorderColor = Color.White;
                Dugme.TextColor = Color.White;
                klikMinute++;
            }
            if (porukeOdg != 0 && minuteOdg != 0 && mbOdg != 0 && cijenaOdg != 0)
            {
                // Enable the submit button
                Prihvati.IsEnabled = true;
            }
            else
            {
                // Disable the submit button
                Prihvati.IsEnabled = false;
            }
        }

        private void DataButton_Clicked(object sender, EventArgs e)
        {
            Dugme = sender as Button;
            if (Dugme.BackgroundColor == Color.FromHex("#fe8402") && klikMB == 1)
            {
                Dugme.BackgroundColor = Color.FromHex("#290a28");
                Dugme.BorderColor = Color.FromHex("#fe8402");
                Dugme.TextColor = Color.White;
                klikMB--;
                mbOdg -= Convert.ToInt32(Dugme.TabIndex);
            }
            else if (klikMB == 0)
            {
                mbOdg = Convert.ToInt32(Dugme.TabIndex);
                Dugme.BackgroundColor = Color.FromHex("#fe8402");
                Dugme.BorderColor = Color.White;
                Dugme.TextColor = Color.White;
                klikMB++;
            }
            if (porukeOdg != 0 &&
        minuteOdg != 0 &&
        mbOdg != 0 &&
        cijenaOdg != 0)
            {
                // Enable the submit button
                Prihvati.IsEnabled = true;
            }
            else
            {
                // Disable the submit button
                Prihvati.IsEnabled = false;
            }
        }

        private void PriceButton_Clicked(object sender, EventArgs e)
        {
            Dugme = sender as Button;
            if (Dugme.BackgroundColor == Color.FromHex("#fe8402") && klikCijena == 1)
            {
                Dugme.BackgroundColor = Color.FromHex("#290a28");
                Dugme.BorderColor = Color.FromHex("#fe8402");
                Dugme.TextColor = Color.White;
                klikCijena--;
                cijenaOdg -= Convert.ToInt32(Dugme.TabIndex);
            }
            else if (klikCijena == 0)
            {
                cijenaOdg = Convert.ToInt32(Dugme.TabIndex);
                Dugme.BackgroundColor = Color.FromHex("#fe8402");
                Dugme.BorderColor = Color.White;
                Dugme.TextColor = Color.White;
                klikCijena++;
            }
            if (porukeOdg != 0 &&
        minuteOdg != 0 &&
        mbOdg != 0 &&
        cijenaOdg != 0 )
            {
                // Enable the submit button
                Prihvati.IsEnabled = true;
            }
            else
            {
                // Disable the submit button
                Prihvati.IsEnabled = false;
            }
        }

        


            List<prikazPaketa> paketi = new List<prikazPaketa>
            {
            new prikazPaketa {ID=1, Naziv = "Extra S", Cijena = "22KM", Poziv = "600", SMS = "600", MB = "6" ,cijenaIndex=1,pozivIndex=2,smsIndex=2,mbIndex=1 },
            new prikazPaketa {ID=2, Naziv = "Extra NET", Cijena = "25KM", Poziv = "400", SMS = "400", MB = "24" ,cijenaIndex=2,pozivIndex=1,smsIndex=1,mbIndex=4},
            new prikazPaketa {ID=3, Naziv = "Extra M", Cijena = "33KM", Poziv = "600", SMS = "600", MB = "8" ,cijenaIndex=3,pozivIndex=2,smsIndex=2,mbIndex=2},
            new prikazPaketa {ID=4, Naziv = "Extra L", Cijena = "44KM", Poziv = "600", SMS = "600", MB = "20",cijenaIndex=4,pozivIndex=2,smsIndex=2,mbIndex=3 },
            new prikazPaketa {ID=5, Naziv = "Extra XL", Cijena = "66KM", Poziv = "1000", SMS = "1000", MB = "50",cijenaIndex=5,pozivIndex=3,smsIndex=3,mbIndex=5 },
            new prikazPaketa {ID=6, Naziv = "Extra XXL", Cijena = "111KM", Poziv = "1500", SMS = "1500", MB = "80" ,cijenaIndex=6,pozivIndex=4,smsIndex=4,mbIndex=6},
            new prikazPaketa {ID=7, Naziv = "Extra PREMIUM", Cijena = "170KM", Poziv = "10000", SMS = "5000", MB = "100" ,cijenaIndex=7,pozivIndex=5,smsIndex=5,mbIndex=7}
            };

            
        
        private void PrihvatiOdg(object sender, EventArgs e)
        {
            OnAlertPaket(sender,e);
        }
        async void OnAlertPaket(object sender, EventArgs e)
        {
            prikazPaketa najboljiPaket = null;
            int rezultat = porukeOdg + minuteOdg + mbOdg + cijenaOdg;
            int max = 99;
            foreach (prikazPaketa paket in paketi)
            {
                int rezultatPaketa = paket.smsIndex +
                                      paket.pozivIndex +
                                      paket.mbIndex +
                                      paket.cijenaIndex;
                if (Math.Abs(rezultat - rezultatPaketa) < max)
                {
                    max = Math.Abs(rezultat - rezultatPaketa);
                    najboljiPaket = paket;
                }
            }
            bool alertOdg = await DisplayAlert("Paket", "Najbolji paket za vas je: " + najboljiPaket.Naziv, "Više o paketu", "Ok");
            if (alertOdg == true)
            { 
                switch (najboljiPaket.ID)
                {
                    case 1:
                        await Navigation.PushAsync(new extras());
                        break;
                    case 2:
                        await Navigation.PushAsync(new ExtraNet());
                        break;
                    case 3:
                        await Navigation.PushAsync(new extram());
                        break;
                    case 4:
                        await Navigation.PushAsync(new extral());
                        break;
                    case 5:
                        await Navigation.PushAsync(new extraxl());
                        break;
                    case 6:
                        await Navigation.PushAsync(new extraxxl());
                        break;
                    case 7:
                        await Navigation.PushAsync(new extrapremium());
                        break;
                }
            }
        }
    }
}