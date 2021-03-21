using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    interface Ibazni
    {
        decimal cena { get; set; }

        int kolicina { get; set; }

        decimal cenaDostave { get; set; }

        string maticnaPloca { get; set; }

        string procesor { get; set; }

        string ram { get; set; }

        string proizvodjac { get; set; }

        string cenaSaPopustom();

        string prodaja(int zahtevanaKolicina);

        string dodajDostavu();

        string ukljuci();

        string iskljuci();
    }

    interface IprenosiviUredjaj
    {
        string baterija { get; set; }
        string rezolucija { get; set; }
        string zvucnici { get; set; }

    }

    interface ImobilniTelefon
    {
        string tipSIMkartice { get; set; }
        string procitajSMS();
    }

    interface Ilaptop
    {
        string pokreniVSCode();
    }

    interface Iracunar
    {
        string grafickaKartica { get; set; }
    }
    interface IgamingKonzola
    {
        int brDzojstika{ get; set; } 
    }
    interface IdesktopRacunar
    {
        string pokreniVisualStudio();
    }

    interface IsingleBoardRacunar
    {
        string konfigurisiGPIO();
    }

}
