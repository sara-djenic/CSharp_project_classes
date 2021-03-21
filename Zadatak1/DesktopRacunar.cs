using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class DesktopRacunar : Racunar, IdesktopRacunar
    {
        public DesktopRacunar(decimal cena, int kolicina, decimal cenaDostave, string maticnaPloca, string procesor, string ram, string proizvodjac, string grafickaKartica)
            : base(cena, kolicina, cenaDostave, maticnaPloca, procesor, ram, proizvodjac, grafickaKartica)
        {

        }
       

        public string pokreniVisualStudio()
        {
            return ("DesktopRacuna-PokreniVisualStudio");
        }
        public override string konfigurisiGrafickuKarticu()
        {
            return ("DesktopRacunar-KonfigurisiGrafickuKarticu");
        }
    }
}
