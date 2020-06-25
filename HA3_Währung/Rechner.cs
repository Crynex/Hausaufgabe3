using System;
using System.Collections.Generic;
using System.Text;

namespace HA3_Währung
{
    class Rechner
    {
        public Währung währung;

        public Rechner(Logik logik)
        {
                      
        }

        public double ausEuro(double geldhaben, string währungsoll)
        {
            double geldsoll = geldhaben;
            double kurs = (double)Währung.kurse[währungsoll];  //Kurs aus Hashtabelle haben * kurs = New Währung              
            geldsoll = geldhaben * kurs;
            return geldsoll;
        }

        public double inEuro(double geldhaben, string währunghaben)
        {
            double geld = geldhaben;
            double kurs = (double)Währung.kurse[währunghaben]; //Kurs aus Hashtabelle haben / kurs = Geld in Währung
            geld = geldhaben / kurs;
            return geld;
        }

        public double andereWährung(double geldhaben, string währunghaben, string währungsoll)
        {
            double geldsoll = geldhaben;
            geldsoll = inEuro(geldhaben, währunghaben); //Kurs in Euro wandeln
            geldhaben = geldsoll;                       
            geldsoll = ausEuro(geldhaben, währungsoll); //Kurs in Fremdwährung wandeln
            return geldsoll;
        }
    }
}
