using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharks.Shared
{
    public class Properties
    //Defining members
    {
        public string cvr_navn, navn, beskrivelse, handicap, vejnavn, postnr, husnr;
        public char kontakt_ved;
        public int antal_pl;

        //constructor 
        public Properties()
        {

        }

        //constructor 
        public Properties(string cn, string n, string b, string h, string vn, char kv, string hn, int ap, string pn)
        {
            cvr_navn = cn;
            navn = n;
            beskrivelse = b;
            handicap = h;
            vejnavn = vn;
            postnr = pn;
            kontakt_ved = kv;
            husnr = hn;
            antal_pl = ap;
        }
        public string CVR_navn
        {
            get { return cvr_navn; }
            set { cvr_navn = value; }
        }
        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }
        public string Beskrivelse
        {
            get { return beskrivelse; }
            set { beskrivelse = value; }
        }
        public string Handicap
        {
            get { return handicap; }
            set { handicap = value; }
        }
        public string Vejnavn
        {
            get { return vejnavn; }
            set { vejnavn = value; }
        }
        public char Kontakt_ved
        {
            get { return kontakt_ved; }
            set { kontakt_ved = value;}
        }
        public string Husnr
        {
            get { return husnr; }
            set { husnr = value; }
        }
        public int Antal_pl
        {
            get { return antal_pl; }
            set { antal_pl = value; }
        }
        public string Postnr
        {
            get { return postnr; }
            set { postnr = value; }
        }
    }

}
