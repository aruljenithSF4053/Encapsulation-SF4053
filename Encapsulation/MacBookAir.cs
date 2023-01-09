using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class MacBookAir : Laptop
    {
        public override void TurnOn()
        {
            base.PowerOn();
            this.BIOSROMLoaded();
            this.RomMemory();
            this.BootFileRunning();
            System.Console.WriteLine("Turning On Mac Book Air ");
        }

        private void BIOSROMLoaded()
        {
            System.Console.WriteLine("BIOS Processing.........");
        }

        private void RomMemory()
        {
            System.Console.WriteLine("ROM Checking.........");
        }
        private void BootFileRunning()
        {
            System.Console.WriteLine("Boot File Running proccess.........");
        }

    }
}