using System;

namespace Recurrsions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recurrsion World!");
            MagicNumber magicNumber = new MagicNumber();
            var num = 83557;
            var result = magicNumber.IsMagicNumber(num);
            Console.WriteLine("Is Magic {0} = {1}", num, result);
            Console.ReadLine();
        }
    }
}
