using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zd4_Lezhen_Andrey_Igorevich;

namespace qwerty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            int First = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int Second = int.Parse(Console.ReadLine());

            int Gcd = NaturalNumbers.GCD(First, Second);

            Console.WriteLine($"НОД({First}, {Second}) = {Gcd}");
        }
    }
}
