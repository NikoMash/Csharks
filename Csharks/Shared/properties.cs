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
        public string cvr_navn, navn, beskrivelse, lang_beskrivelse, handicap, vejnavn, postnr_by, husnr, postnr;
        public char kontakt_ved;
        public int antal_pl;

        //constructor 
        public Properties()
        {

        }

        //constructor 
        public Properties(string cn, string n, string b, string lb, string h, string vn, string pnb, char kv, string hn, int ap, string pn)
        {
            cvr_navn = cn;
            navn = n;
            beskrivelse = b;
            lang_beskrivelse = lb;
            handicap = h;
            vejnavn = vn;
            postnr_by = pnb;
            postnr = pn;
            kontakt_ved = kv;
            husnr = hn;
            antal_pl = ap;
            postnr = pn;
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
        public string Lang_beskrivelse
        {
            get { return lang_beskrivelse; }
            set { lang_beskrivelse = value; }
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
        public string Postnr_by
        {
            get { return postnr_by; }
            set { postnr_by = value; }
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
