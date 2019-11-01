using System;
using Zoologico.Interfaces;

namespace Zoologico.Models
{
    public class Golfinho : Animal, IAquatico
    {
        public string Nadar()
        {
            return this.GetType().Name;
        }
    }
}