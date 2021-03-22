using System;
using System.Collections.Generic;
using System.Text;

namespace Week1.Classi
{
    public class Employee : Person 
    {
        //Metodo
        public string Dettagli()
        {
            return Cognome + " (" + NumeroFigli + ")";
        }

        public override string NomeCompleto(string titolo)
        {
            return $"[Impiegat{titolo}] " + Nome + " " + Dettagli();
        }
    }
}
