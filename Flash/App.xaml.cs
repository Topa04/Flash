using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using SQLite;


namespace Flash
{
    public partial class App : Application
    {
        private static Baza bazaPodataka;
        public static Baza BazaPodataka
        {
            get
            {
                if (bazaPodataka == null)
                {
                    bazaPodataka = new Baza(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "korisnici.db3"));
                }

                return bazaPodataka;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
