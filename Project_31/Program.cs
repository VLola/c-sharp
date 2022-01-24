using System;

namespace Project_31
{
    class Program
    {
        static void Main(string[] args)
        {
            MiracleOne.MiracleOne One = new MiracleOne.MiracleOne();
            MiracleTwo.MiracleTwo Two = new MiracleTwo.MiracleTwo();
            MiracleThree.MiracleThree Three = new MiracleThree.MiracleThree();
            MiracleFour.MiracleFour Four = new MiracleFour.MiracleFour();
            MiracleFive.MiracleFive Five = new MiracleFive.MiracleFive();
            MiracleSix.MiracleSix Six = new MiracleSix.MiracleSix();
            MiracleSeven.MiracleSeven Seven = new MiracleSeven.MiracleSeven();
            Console.WriteLine("7 Чудес света:");
            One.Print();
            Two.Print();
            Three.Print();
            Four.Print();
            Five.Print();
            Six.Print();
            Seven.Print();
        }
    }
}
