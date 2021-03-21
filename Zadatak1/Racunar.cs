using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Racunar : BaznaKlasa, Iracunar
    {
        public Racunar(decimal cena, int kolicina, decimal cenaDostave, string maticnaPloca, string procesor, string ram, string proizvodjac, string grafickaKartica) 
            : base ( cena, kolicina,  cenaDostave,  maticnaPloca,  procesor,  ram,  proizvodjac)
        {
            this.grafickaKartica = grafickaKartica;
        }


        private string _grafickaKartica;

       

        public string grafickaKartica
        {
            get { return _grafickaKartica; }
            set { _grafickaKartica = value; }
        }

        public virtual string konfigurisiGrafickuKarticu()
        {
            return ("Racunar-KonfigurisiGrafickuKarticu");
        }

    }
}
