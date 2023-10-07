using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Flash
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class admin : ContentPage
    {
        public admin()
        {
            InitializeComponent();
        }

        private async void prikaziKorisnike(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new prikazSvihKorisnika());
        }

        private async void prikaziPoruke(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new prikazPoruka());

        }
    }
}