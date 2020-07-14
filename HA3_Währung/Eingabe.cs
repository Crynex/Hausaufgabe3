using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using HA3_Währung;

namespace HA3_Währung
{
    class Eingabe
    {
        private Logik logik;

        public Eingabe(Logik logik)
        {
            this.logik = logik;       
        }

        public string Anweisung()
        {
            string anweisung = ("Bitte geben Sie Ihren Währungscode ein: " +
                    "\n Code: USD - USDollar " +
                    "\n Code: GBP - Britische Pfund" +
                    "\n Code: CHF - Schweizer Franken" +
                    "\n Code: JPY - Japanischer Yen" +
                    "\n Code: PLN - Polnischer Zloty" +
                    "\n Code: TRY - Türkische Lira" +
                    "\n Code: RUB - Rüssischer Rubel" +
                    "\n Code: DKK - Dänische Krone" +
                    "\n Code: CZK - Tschechische Krone" +
                    "\n Code: SEK - Schwedische Krone" +
                    "\n Code: RON - Rumänische Leu" +
                    "\n Code: HRK - Kroatische Kuna" +
                    "\n Code: INR - Indische Rupie" +
                    "\n Code: AUD - Australischer Dollar" +
                    "\n Code: CAD - Kanadischer Dollar" +
                    "\n" +
                    "\n Ihr Währungscode: " +
                    "\n");

            return anweisung;
        }
        public string Währunghaben()
        {
            string ausgabeanweisung = Anweisung();
            Console.Write(ausgabeanweisung + "\n Bitte geben Sie die Habenwährung ein: ");

            string währunghaben = Console.ReadLine();
            
            if (Währung.kurse.ContainsKey(währunghaben))
            {
                return währunghaben;
            } else 
            {
                Console.Write("Bitte geben Sie eine gültige Währung ein!\n");
                new Logik();
            }                
            return null;
            
        }

        public string WährungSoll()
        {
            string ausgabeanweisung = Anweisung();            
            Console.WriteLine("Bitte geben Sie die Währung in die Sie wechseln möchten ein: ");

            string währungsoll = Console.ReadLine();
            if (Währung.kurse.ContainsKey(währungsoll))
            {
                return währungsoll;
            }
            else
            {
                Console.Write("Bitte geben Sie eine gültige Währung ein!");
                new Logik();
            }
            return null;
        }

        public double Betraghaben()
        {
            Console.WriteLine("Bitte geben Sie den Betrag den Sie wechseln möchten ein: ");
            double haben = 0;
            try
            {
                haben = Convert.ToDouble(Console.ReadLine());               
            }
            catch (Exception ex)
            {                
                Console.Clear();
                Console.WriteLine("!Bitte geben Sie eine Zahl ein!\n");
                new Logik();
            }

            if(haben > 0)
            {
                return Math.Round(haben, 2);
            } else
            {
                Console.Clear();
                Console.WriteLine("Bitte geben Sie eine Zahl größer 0 ein: ");
                new Logik();
            }
            return haben;
        }
    }
}
