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
    public partial class lokacija5 : ContentPage
    {
        public lokacija5()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Map.OpenAsync(43.8556634, 18.4088297);
        }
    }
}