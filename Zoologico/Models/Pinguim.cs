using System;
using Zoologico.Interfaces;

namespace Zoologico.Models
{
    public class Pinguim : Animal, IPolar
    {
        public string  ResistirAoFrio()
        {
            return this.GetType().Name;
        }
    }
}