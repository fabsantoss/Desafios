using System;
using Zoologico.Interfaces;
namespace Zoologico.Models
{
    public class Tucano : Animal, IVoador
    {
        public string Voar()
        {
            return this.GetType().Name;
        }
    }
}