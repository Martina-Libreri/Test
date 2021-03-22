using System;
using System.Collections.Generic;
using System.Text;
using Week1.Classi.Interfaces;

namespace Week1.Classi
{
    public class Person : ILogging
    {
        //Campi
        private string _codiceFiscale;

        //Proprietà
        public string CodiceFiscale { get { return _codiceFiscale; } set { _codiceFiscale = value; } }
        public string Nome { get; set; }
        //possiamo strivere prop e schiacciare due volte tab
        public string Cognome { get; set; }
        public DateTime DataDiNascita { get; set; }
        public int NumeroFigli { get; set; }

        //Metodi -> sono le funzionalità che può avere una determinata classe

        public virtual string NomeCompleto(string titolo) //le classi che derivano da person possono attingere al metodo o modificarlo
        {
            //questi più per le stringhe fanno una concatenazione
            return "[" + titolo + "]" + " " + Nome + " " + Cognome;
        }

        public void LogInfo(string message)
        {
            Console.WriteLine("[INFO] {0}", message);
        }

        public void LogWarning(string message)
        {
            Console.WriteLine("[WARNING] {0}", message);
        }

        public void LogError(string message)
        {
            Console.WriteLine("[ERROR] {0}", message);
        }

        

    }
}
