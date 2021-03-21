using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    class PrenosiviUredjaj : BaznaKlasa, IprenosiviUredjaj
    {
        public PrenosiviUredjaj(decimal cena, int kolicina, decimal cenaDostave, string maticnaPloca, string procesor, string ram, string proizvodjac, string baterija)
            : base(cena, kolicina, cenaDostave, maticnaPloca, procesor, ram, proizvodjac)
        {
            this.baterija = baterija;
        }

        private string _baterija;

        public string baterija
        {
            get { return _baterija; }
            set { _baterija = value; }
        }

        private string _rezolucija;

        public string rezolucija
        {
            get { return _rezolucija; }
            set { _rezolucija = value; }
        }

        private string _zvucnici;

        public string zvucnici
        {
            get { return _zvucnici; }
            set { _zvucnici = value; }
        }

        public virtual string unesiTekst()
        {
            return ("PrenosiviUredjaj-unesiTekst");
        }

    }
}
