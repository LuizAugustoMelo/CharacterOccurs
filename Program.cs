using Entities;
using Entities.Exceptions;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterOccurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Page to count the number of occurence of the character in a word or phrase");
            Console.Write("Entre com uma palavra ou frase: ");
            string phrase = Console.ReadLine();

            try
            {
                CounterApp counterApp = new CounterApp();
                List<CounterClass> counterClasses = counterApp.GetNumberOfChars(phrase);
                StringBuilder sb = new StringBuilder();

                foreach (CounterClass c in counterClasses.OrderByDescending(x => x.Count))
                {
                    if (c.Count > 1)
                    {
                        sb.Append($"{c.Character} = {c.Count}, ");
                    }
                }

                Console.WriteLine(sb.ToString().Trim().Remove(sb.Length - 2));
            }
            catch (CounterException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
