using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project07_Detrermine_a_candidate_s_age_for_vote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Candiateage;

            Console.WriteLine("Input the age of the candidate : ");
            Candiateage = Convert.ToInt32(Console.ReadLine());

            if (Candiateage < 18)
            {
                Console.WriteLine("Sorry, You are not eligible to caste your vote.\n");
                Console.WriteLine(18 - Candiateage + "You would be able to caste your vote after %d year.\n");
            }

            else
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.\n");
            }

            Console.ReadLine();
        }
    }
}
