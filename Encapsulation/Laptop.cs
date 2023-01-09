using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulation
{
    public abstract  class Laptop
    {
        public abstract void TurnOn();

        protected void PowerOn()
        {
            System.Console.WriteLine("Checking Proccessors....");
            System.Console.WriteLine("Checking network.....");
            System.Console.WriteLine("Checking memory.......");
        }
        
    }
}