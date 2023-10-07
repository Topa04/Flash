using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Flash
{
    public class Korisnici 
    {
        [PrimaryKey,AutoIncrement]public int ID { get; set; }
        public string korisnickoIme { get; set; }
        public string brojTelefona { get; set; }
        public string Sifra { get; set; }

    }
}