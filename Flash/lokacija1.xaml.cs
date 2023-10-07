using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Flash
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class lokacija1 : ContentPage
    {
        public lokacija1()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Map.OpenAsync(43.857648, 18.4211679);
        }
    }
}