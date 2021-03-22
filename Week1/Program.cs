using System;
using Week1.Classi;
using Week1.Esercitazione1;

namespace Week1
{
    //da dove entra l'applicazione
    class Program
    {
        //Dichiaro un delegate che quando vado ad implementarlo avrà bisogno di un implementazione che sarà un metodo
        //è un'asttrazione
        delegate int Somma(int primoNumero, int secondoNumero);
        static void Main(string[] args)
        {
            //Funzonalità.EserciziTipo();

            // Funzonalità.EserciziClassi();

            //Funzonalità.EsercizioInterfacce();

            //Funzonalità.Esercitazione();

            //abbiamo associato alla variabile somma il metodo mysum
            Somma somma = new Somma(Funzonalità.MySum);
            int risultato = somma(1, 2);
            Console.WriteLine($"Il risultato è {risultato}");

        }
    }
}
