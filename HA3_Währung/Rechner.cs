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
            return Math.Round(geldsoll, 2);
        }

        public double inEuro(double geldhaben, string währunghaben)
        {
            double geldsoll = geldhaben;
            double kurs = (double)Währung.kurse[währunghaben]; //Kurs aus Hashtabelle haben / kurs = Geld in Währung
            try
            {
                geldsoll = geldhaben / kurs;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hier wurde durch 0 geteilt");
            }
            return Math.Round(geldsoll, 2);
        }

        public double andereWährung(double geldhaben, string währunghaben, string währungsoll)
        {
            double geldsoll = geldhaben;
            geldsoll = inEuro(geldhaben, währunghaben); //Kurs in Euro wandeln
            geldhaben = geldsoll;                       
            geldsoll = ausEuro(geldhaben, währungsoll); //Kurs in Fremdwährung wandeln
            return Math.Round(geldsoll, 2);
        }
    }
}
