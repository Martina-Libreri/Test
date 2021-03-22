using System;
using System.Collections.Generic;
using System.Text;

namespace Week1.Esercitazione1.Interfaces
{
    public interface IFileSerializable
    {
        public void SaveToFile(string fileName);
        public void LoadFromFile(string fileName);
    }
}
