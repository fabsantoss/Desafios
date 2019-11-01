using System;
using Zoologico.Interfaces;

namespace Zoologico.Models
{
    public class Chimpanze : Animal, ITerrestre
    {
        public string Andar()
        {
            return this.GetType().Name;
        }
    }
}