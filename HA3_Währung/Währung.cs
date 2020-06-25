using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace HA3_Währung
{
    class Währung
    {

        public static Hashtable kurse; 

        //Kurse im Verhältnis zu Euro
        public Währung()
        {
            kurse = new Hashtable();

            kurse.Add("USD", 1.11758); //US-Dollar
            kurse.Add("GBP", 0.90477); //Britische Pfund
            kurse.Add("CHF", 1.06429); //Schweizer Franken
            kurse.Add("JPY", 119.4850); //Japanischer Yen
            kurse.Add("PLN", 4.4494); //Polnische Zloty
            kurse.Add("TRY", 7.6547); //Türkische Lira
            kurse.Add("RUB", 77.6765); //Russischer Rubel
            kurse.Add("DKK", 7.4576); //Dänische Krone
            kurse.Add("CZK", 26.6550); //Tschechische Krone
            kurse.Add("SEK", 10.5758); //Schwedische Krone
            kurse.Add("RON", 4.8429); //Rumänische Leu
            kurse.Add("HRK", 7.5713); //Kroatische Kuna
            kurse.Add("INR", 85.2634); //Indische Rupie
            kurse.Add("AUD", 1.6404); //Australischer Dollar
            kurse.Add("CAD", 1.5225); //Kanadischer Dollar
        }                                     
    }
}
