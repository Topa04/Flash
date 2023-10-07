using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Flash
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Poruka : ContentPage
    {
        public Poruka(Poruke SelektovanaPoruka)
        {
            InitializeComponent();
            korisnickoImeIPrezime.Text = SelektovanaPoruka.korisnickoImeIPrezime;
            EMail.Text = SelektovanaPoruka.Email;
            naslovPoruke.Text = SelektovanaPoruka.naslovPoruke;
            tekstPoruke.Text = SelektovanaPoruka.tekstPoruke;
        }
        
    }
}