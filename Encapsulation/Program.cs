using System;
namespace Encapsulation;
class Program
{
    public static void Main(string[] args)
    {
        Laptop lenovoIdeaPad=new LenovoIdeaPad();
        lenovoIdeaPad.TurnOn();

        Laptop macBookAir=new MacBookAir();
        macBookAir.TurnOn();

       /* Laptop lap=new Laptop();
        lap.TurnOn();
        lap.PowerOn();
        */
    }
}