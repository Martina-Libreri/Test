using System;
using System.Collections.Generic;
using System.Text;
using Week1.Classi;
using Week1.Classi.Interfaces;
using Week1.Esercitazione1;
using Week1.Esercitazione1.Interfaces;

namespace Week1
{
    //la marchiamo pubblica per renderla visibile da tutto il codice
    public class Funzonalità
    {
        //la usiamo come classe di appoggio
        public static void EserciziTipo()
        {
            //Value type e Reference Type
            //Value type
            bool x = true;

            bool z = !x;
            // possiamo vedere il contenuto delle variabili a console o tramite breakpoint
            Console.WriteLine("Il valore z = {0}", z);
        }

        public static void EserciziClassi()
        {
            Console.WriteLine("________Classi________");
            //creiamo una variabile che sa di tipo person
            Person persona = new Person();
            persona.Nome = "Mario";
            persona.Cognome = "Rossi";
            persona.CodiceFiscale = "RSSMRI40f39d504g";
            persona.DataDiNascita = new DateTime(1940, 04, 16);

            //Mentre le instanziamo diciamo il valore
            Person persona2 = new Person()
            {
                Nome = "Alessia",
                Cognome = "Bianchi",
                CodiceFiscale = "BCHLSS£fH)$HKgO£)"
            };

            Console.WriteLine(persona.NomeCompleto("Signor"));

            Console.WriteLine(persona2.NomeCompleto("Signora"));

            Employee employee = new Employee()
            {
                Nome = "Ettore",
                Cognome = "Rossi",
                NumeroFigli = 2
            };
            Console.WriteLine(employee.NomeCompleto("o"));

            
        }

        public static void EsercizioInterfacce()
        {
            Person p = new Person()
            {
                Nome = "Pio",
                Cognome = "Rossi",
                DataDiNascita = new DateTime(1969, 08, 29),
                CodiceFiscale = "FIBU58VNG9F"
            };

            p.LogInfo("Il Log non funziona");
            Person person = new Employee()
            {
                Nome = "Alice",
                Cognome = "Colella"
            };
            //il metodo è anche nell'istanza di employee anche se non viene implementata dall'intefaccia
            //ma il tipo person che è la classe padre di employee lo ha
            person.LogInfo("Message");

            Computer myComputer = new Computer()
            {
                Model = "DELL XPS 9570"
            };

            myComputer.LogInfo("Funiona");

            ILogging[] loggingItems = { myComputer, p };
            foreach(ILogging item in loggingItems)
            {
                item.LogInfo("Prova");
            }

        }


        public static void Esercitazione()
        {
            Console.WriteLine("___________Esercitazione 1______________");

            //istanza di Cerchio ma di tipo FormeGeometriche quindi non ha le proprietà del cerchio.
            FormeGeometriche forme = new Cerchio();


            Cerchio c = new Cerchio()
            {
                Nome = "Cerchio",
                X = 3,
                Y = 4,
                Raggio = 6
            };
            Triangolo t = new Triangolo()
            {
                Nome = "Triangolo",
                Base = 4,
                Altezza = 3
            };
            Rettangolo r = new Rettangolo()
            {
                Nome = "Rettangolo",
                Altezza = 2,
                Larghezza = 4
            };

            Console.WriteLine(c.CalcoloArea());
            Console.WriteLine(c.DisegnoForma());
            Console.WriteLine(t.CalcoloArea());
            Console.WriteLine(t.DisegnoForma());
            Console.WriteLine(r.CalcoloArea());
            Console.WriteLine(r.DisegnoForma());

            Console.WriteLine("___________Esercitazione 2______________");
            c.SaveToFile("Test");
            Cerchio circle = new Cerchio();
            circle.LoadFromFile("Test");

            IFileSerializable[] file = { c };
            foreach (var item in file)
            {
                item.SaveToFile("C");
                item.LoadFromFile("C");
            }

        }

        public static int MySum(int a, int b)
        {
            return a + b;
        }
        
    }


    
}
