using System;
using System.Xml;

namespace inlam_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I detta program ska du skriva in fem namn");
            string[] namn = new string[5];

            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine($"Skriv in ett namn");
                namn[i] = Console.ReadLine();
            }

            Console.WriteLine("Här är de namnen du skrev in");

            foreach (string i in namn)
            {
                Console.WriteLine(i);
            }
            
           
            
        }
    }
}