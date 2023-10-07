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
    public partial class telefon : ContentPage
    {
        public telefon()
        {
            InitializeComponent();
        }

        private void Nazad(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        
    }
}