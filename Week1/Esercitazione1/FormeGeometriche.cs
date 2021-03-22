using System;
using System.Collections.Generic;
using System.Text;

namespace Week1.Esercitazione1
{
    public abstract class FormeGeometriche
    {
        //Proprietà
        public string Nome { get; set; }

        //Metodi
        public abstract double CalcoloArea();
        public abstract string DisegnoForma();
        
    }
}
