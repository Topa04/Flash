using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flash
{
    public class Poruke
    {
        [PrimaryKey, AutoIncrement] public int ID { get; set; }
        public string korisnickoImeIPrezime { get; set; }
        public string Email { get; set; }
        public string naslovPoruke { get; set; }
        public string tekstPoruke { get; set; }

    }
}
