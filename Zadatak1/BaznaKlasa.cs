using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{


    public class BaznaKlasa : Ibazni
    {
        public BaznaKlasa(decimal cena, int kolicina, decimal cenaDostave, string maticnaPloca, string procesor, string ram, string proizvodjac)
        {
            this.cena = cena;
            this.kolicina = kolicina;
            this.cenaDostave = cenaDostave;
            this.maticnaPloca = maticnaPloca;
            this.procesor = procesor;
            this.ram = ram;
            this.proizvodjac = proizvodjac;
        }

        private decimal _cena;

        public decimal cena
        {
            get { return _cena; }
            set 
            {
                if (value > 0)
                {
                    _cena = value;
                }
                else
                {
                    throw new Exception("Cena mora biti veca od 0");
                }
            }
        }
        
        public string cenaSaPopustom()
        {
            return ("BaznaKlasa-CenaSaPopustom");
        }

        private int _kolicina;

        public int kolicina
        {
            get { return _kolicina; }
            set 
            { 
                if(value > 0)
                {
                    _kolicina = value;
                }
                else
                {
                    throw new Exception("Kolicina mora biti veca od 0");
                }
            }
        }

        public string prodaja(int zahtevanaKolicina)
        {
            return ("BaznaKlasa-Prodaja");
        }

        private decimal _cenaDostave;

        public decimal cenaDostave
        {
            get { return _cenaDostave; }
            set { _cenaDostave = value; }
        }

        public string dodajDostavu()
        {
            return ("BaznaKlasa-DodajDostavu");
        }

        private string _maticnaPloca;

        public string maticnaPloca
        {
            get { return _maticnaPloca; }
            set { _maticnaPloca = value; }
        }

        private string _procesor;

        public string procesor
        {
            get { return _procesor; }
            set { _procesor = value; }
        }

        private string _ram;

        public string ram
        {
            get { return _ram; }
            set { _ram = value; }
        }

        private string _proizvodjac;

       

        public string proizvodjac
        {
            get { return _proizvodjac; }
            set { _proizvodjac = value; }
        }


        public string ukljuci ()
        {
            return ("BaznaKlasa-Uskljuci");
        }

        public string iskljuci()
        {
            return ("BaznaKlasa-Iskljuci");
        }
    }
}
