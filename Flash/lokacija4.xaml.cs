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
    public partial class lokacija4 : ContentPage
    {
        public lokacija4()
        {
            InitializeComponent();
        }
        async void Button_Clicked(object sender, EventArgs e)
        {
            await Map.OpenAsync(43.82992, 18.3071363);
        }
    }
}