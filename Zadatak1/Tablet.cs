using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class Tablet : PrenosiviUredjaj
    {
        public Tablet(decimal cena, int kolicina, decimal cenaDostave, string maticnaPloca, string procesor, string ram, string proizvodjac, string baterija)
            : base(cena, kolicina, cenaDostave, maticnaPloca, procesor, ram, proizvodjac, baterija)
        {

        }

        public string citajKnjigu()
        {
            return ("SingleBoardRacunar-CitajKnjigu");
        }
        public override string unesiTekst()
        {
            return ("Laptop-UnesiTekst");
        }
    }
}
