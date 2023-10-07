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
    public partial class lokacija3 : ContentPage
    {
        public lokacija3()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            await Map.OpenAsync(43.8524558, 18.3815639);
        }
    }
}