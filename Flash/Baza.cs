using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Flash
{
    public class Baza
    {
        private readonly SQLiteAsyncConnection _baza;
        public Baza(string dbPath)
        {
            _baza= new SQLiteAsyncConnection(dbPath);
            _baza.CreateTableAsync<Korisnici>();
            _baza.CreateTableAsync<Poruke>();
        }
        public Task<List<Korisnici>> GetKorisnici() 
        {
            return _baza.Table<Korisnici>().ToListAsync();
        }

        public Task<int> SaveKorisnik(Korisnici korisnik)
        {
            return _baza.InsertAsync(korisnik);
        }

        public Task<List<Poruke>> GetPoruke()
        {
            return _baza.Table<Poruke>().ToListAsync();
        }

        public Task<int> SpasiPoruku(Poruke poruka)
        {
            return _baza.InsertAsync(poruka);
        }

        public Task<int> IzbrisiKorisnika(Korisnici korisnik)
        {
            return _baza.DeleteAsync(korisnik);
        }

        public Task<int> IzbrisiPoruku(Poruke poruka)
        {
            return _baza.DeleteAsync(poruka);
        }
    }
}
