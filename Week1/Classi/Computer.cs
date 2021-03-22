using System;
using System.Collections.Generic;
using System.Text;
using Week1.Classi.Interfaces;

namespace Week1.Classi
{
    public class Computer : ILogging
    {
        public string Model { get; set; }


        //Metodi
        public void LogInfo(string message)
        {
            Console.WriteLine("[INFO] {0} (C)", message);
        }

        public void LogWarning(string message)
        {
            Console.WriteLine("[WARNING] {0} (C)", message);
        }

        public void LogError(string message)
        {
            Console.WriteLine("[ERROR] {0} (C)", message);
        }
    }
}
