using System;
using System.Collections.Generic;
using System.Text;

namespace Week1.Classi.Interfaces
{
    public interface ILogging
    {
        //Andiamo a mettere i metodi che dovranno essere implementati in tutte le classi che avranno qusta interfaccia
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message);
    }
}
