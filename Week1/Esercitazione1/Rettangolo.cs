using System;
using System.Collections.Generic;
using System.Text;

namespace Week1.Esercitazione1
{
    public class Rettangolo : FormeGeometriche 
    {
        public double Larghezza { get; set; }
        public double Altezza { get; set; }

        public override double CalcoloArea()
        {
            return Larghezza * Altezza;
        }

        public override string DisegnoForma()
        {
           return $"{Larghezza} * {Altezza}";
        }
    }
}
