using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class MobilniTelefon : PrenosiviUredjaj, ImobilniTelefon 
    {
        public MobilniTelefon(decimal cena, int kolicina, decimal cenaDostave, string maticnaPloca, string procesor, string ram, string proizvodjac, string baterija, string tipSIMkartice)
            : base(cena, kolicina, cenaDostave, maticnaPloca, procesor, ram, proizvodjac, baterija)
        {
            this.tipSIMkartice = tipSIMkartice;
        }
        private string _tipSIMkartice; 

        public string tipSIMkartice
        {
            get { return _tipSIMkartice; }
            set 
            { 
                if(value == "mini" || value == "macro" || value == "nano")
                {
                    _tipSIMkartice = value;
                }
                else
                {
                    throw new Exception("Neispravan tip SIM kartice");
                }
            }
        }

        public string procitajSMS()
        {
            return ("BaznaKlasa-ProcitajSMS");
        }
        public override string unesiTekst()
        {
            return ("Laptop-UnesiTekst");
        }
    }
}
