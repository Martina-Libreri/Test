using System;
using System.Collections.Generic;
using System.Text;

namespace Week1.Esercitazione1
{
    public class Triangolo : FormeGeometriche 
    {
        public double Base { get; set; }
        public double Altezza { get; set; }

        public override double CalcoloArea()
        {
            return (Base * Altezza) / 2;
        }

        public override string DisegnoForma()
        {
            return $"[{Base} * {Altezza}] / 2";
        }
    }
}
