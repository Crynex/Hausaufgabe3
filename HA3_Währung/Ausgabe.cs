﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HA3_Währung
{
    class Ausgabe
    {

        //evtl override mit einbauen

        public Ausgabe(string währunghaben, string währungsoll, double geldhaben, double geldchanged)
        {            
            Console.WriteLine("Sie haben " + geldhaben + " " + währunghaben + " in " + geldchanged + " " + währungsoll + " getauscht.");
        }
        
    }
}
