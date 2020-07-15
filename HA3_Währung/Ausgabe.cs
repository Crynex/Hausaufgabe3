using System;
using System.Collections.Generic;
using System.Text;

namespace HA3_Währung
{
    class Ausgabe
    {
        private String _währunghaben;
        private String _währungsoll;
        private double _geldhaben;
        private double _geldchanged;
        public Ausgabe(string währunghaben, string währungsoll, double geldhaben, double geldchanged)
        {
            _währunghaben = währunghaben;
            _währungsoll = währungsoll;
            _geldhaben = geldhaben;
            _geldchanged = geldchanged;
        }
        public override string ToString()
        {
            return "Sie haben " + _geldhaben + " " + _währunghaben + " in " + _geldchanged + " " + _währungsoll + " getauscht.";
        }
        
        
    }
}
