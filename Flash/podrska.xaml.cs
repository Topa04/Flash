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
    public partial class podrska : ContentPage
    {
        public podrska()
        {
            InitializeComponent();
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new telefon()));
        }
        private void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new internet()));
        }
        private void TapGestureRecognizer_Tapped2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new mojatv()));
        }
        private void TapGestureRecognizer_Tapped3(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new mobitel()));
        }
        private void TapGestureRecognizer_Tapped4(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new servis()));
        }
        private void TapGestureRecognizer_Tapped5(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new dodatneusluge()));
        }
    }
}