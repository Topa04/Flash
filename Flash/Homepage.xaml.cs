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
    public partial class Homepage : ContentPage
    {
        public Homepage()
        {
            InitializeComponent();
        }
        private  void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new podrska());
        }
         private void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new paket());
        }
        private  void TapGestureRecognizer_Tapped2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
        private  void TapGestureRecognizer_Tapped3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new pitanje());
        }
    }
}