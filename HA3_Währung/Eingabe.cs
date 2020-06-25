using System;
using System.Collections.Generic;
using System.Text;

namespace HA3_Währung
{
    class Eingabe
    {
        private Logik logik;

        public Eingabe(Logik logik)
        {
            this.logik = logik;       
        }

        public string Währunghaben()
        {
            Console.WriteLine("Bitte geben Sie Ihre Währung ein: ");
            string währunghaben = Console.ReadLine();
            return währunghaben;
        }

        public string WährungSoll()
        {
            Console.WriteLine("Bitte geben Sie die Währung in die Sie wechseln möchten ein: ");
            string währungsoll = Console.ReadLine();
            return währungsoll;
        }

        public double Betraghaben()
        {
            Console.WriteLine("Bitte geben Sie den Betrag den Sie wechseln möchten ein: ");
            double haben = Convert.ToDouble(Console.ReadLine());
            return Math.Round(haben, 2);
        }
    }
}
