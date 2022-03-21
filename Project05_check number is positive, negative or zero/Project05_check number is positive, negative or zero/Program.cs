using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project05_check_number_is_positive__negative_or_zero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Enter number is positive ");
            }
            else if (num < 0)
            {
                Console.WriteLine("Enter number is nagative ");
            }
            else
            {
                Console.WriteLine("Enter number is zero ");
            }

            Console.ReadLine();
        }
    }
}
