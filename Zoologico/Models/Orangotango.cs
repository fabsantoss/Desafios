using System;
using Zoologico.Interfaces;

namespace Zoologico.Models
{
    public class Orangotango : Animal, ITerrestre
    {
        public string Andar()
        {
            return this.GetType().Name;
        }
    }
}