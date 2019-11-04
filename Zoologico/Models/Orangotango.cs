using System;
using Zoologico.Interfaces;

namespace Zoologico.Models.Animais
{
    public class Orangotango : Animal, ITerrestre
    {
        public string Andar()
        {
            return this.GetType().Name;
        }
    }
}