using System;
using Zoologico.Interfaces;

namespace Zoologico.Models
{
    public class Tartaruga :  Animal, IAquatico
    {
        public string Nadar()
        {
            return this.GetType().Name;
        }
    }
}