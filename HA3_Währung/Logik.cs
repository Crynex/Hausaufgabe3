using System;
using System.Collections.Generic;
using System.Text;

namespace HA3_Währung
{
    class Logik
    {
        public Eingabe eingabe;
        public Rechner rechner;
        public Ausgabe ausgabe;
        public Logik()
        {
            new Währung();
            eingabe = new Eingabe(this);
            rechner = new Rechner(this);
            Eingaben();            
        }

        public void Eingaben()
        {
            string währunghaben = eingabe.Währunghaben();
            string währungsoll = eingabe.WährungSoll();
            double geldhaben = eingabe.Betraghaben();

            double geldchanged = umrechnen(geldhaben, währungsoll, währunghaben);

            Ausgabe ausgabe = new Ausgabe(währunghaben, währungsoll, geldhaben, geldchanged);
            Console.WriteLine(ausgabe.ToString());
        }



        public double umrechnen(double geldhaben, string währungsoll, string währunghaben)
        {
            if (währunghaben == "EUR")
            {
                return rechner.ausEuro(geldhaben, währungsoll); ;
            }
            else if (währunghaben != "EUR" && währungsoll == "EUR")
            {
                return rechner.inEuro(geldhaben, währunghaben);
            }
            else if (währunghaben != "EUR" && währungsoll != "EUR")
            {
                return rechner.andereWährung(geldhaben, währunghaben, währungsoll);
            }
            else
            {
                return geldhaben;
            }
        }
    }
}
