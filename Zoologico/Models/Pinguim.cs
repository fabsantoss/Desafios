using System;
using Zoologico.Interfaces;

namespace Zoologico.Models.Animais
{
    public class Pinguim : Animal, IPolar
    {
        public string  ResistirAoFrio()
        {
            return this.GetType().Name;
        }
    }
}