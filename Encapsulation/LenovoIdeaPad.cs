using System.Runtime.ConstrainedExecution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class LenovoIdeaPad:Laptop
    {

        public override void TurnOn()
        {
            base.PowerOn();
            System.Console.WriteLine();
            this.BIOSROM();
            this.OperatingSystemPhase();
            this.Securitycheck();
           System.Console.WriteLine("Turning On LenovoIdeaPad ");
        }

        private void BIOSROM()
        {
            System.Console.WriteLine("BIOS Processing.........");
        }

        private void OperatingSystemPhase()
        {
            System.Console.WriteLine("Operating Phase.........");
        }
        private void Securitycheck()
        {
            System.Console.WriteLine("checking proccess.........");
        }

    }
}