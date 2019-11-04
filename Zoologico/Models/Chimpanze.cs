using System;
using Zoologico.Interfaces;

namespace Zoologico.Models.Animais
{
    public class Chimpanze : Animal, ITerrestre
    {
        public string Andar()
        {
            return this.GetType().Name;
        }
    }
}