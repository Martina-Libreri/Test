using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Week1.Esercitazione1.Interfaces;

namespace Week1.Esercitazione1
{
    public class Cerchio : FormeGeometriche, IFileSerializable 
    {
        public int X { get; set; }
        public int Y { get; set; }
        public double Raggio { get; set; }

        public override double CalcoloArea()
        {
            return Math.Pow(Raggio,2) * Math.PI;
        }

        public override string DisegnoForma()
        {
            return $"[{X},{Y}] Raggio:" + Raggio;
        }

        public void LoadFromFile(string fileName)
        {
            Console.WriteLine("Caricato dal file {0}", fileName);

        }

        public void SaveToFile(string fileName)
        {
            Console.WriteLine("Salvato sul file {0}", fileName); 
        }
    }
}
