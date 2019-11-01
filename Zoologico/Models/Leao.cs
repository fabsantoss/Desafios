using System;
using Zoologico.Interfaces;

namespace Zoologico.Models
{
    public class Leao :  Animal, ITerrestre
    {
        public string Andar()
        {
            return this.GetType().Name;
        }
    }
}