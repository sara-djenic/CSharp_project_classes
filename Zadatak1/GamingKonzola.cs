using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class GamingKonzola : Racunar, IgamingKonzola
    {
        public GamingKonzola(decimal cena, int kolicina, decimal cenaDostave, string maticnaPloca, string procesor, string ram, string proizvodjac, string grafickaKartica, int brDzojstika)
            : base(cena, kolicina, cenaDostave, maticnaPloca, procesor, ram, proizvodjac, grafickaKartica)
        {
            this.brDzojstika = brDzojstika;
        }
        private int _brDzojstika;

        public int brDzojstika
        {
            get { return _brDzojstika; }
            set 
            {
                if (value < 0)
                {
                    throw new Exception("Broj dzojstika ne moze biti negativan");
                }
                else
                {
                    _brDzojstika = value;
                }
            }
        }
        public override string konfigurisiGrafickuKarticu()
        {
            return ("GamingKonzola-KonfigurisiGrafickuKarticu");
        }

    }
}
