using Entities.Exceptions;
using Entities.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Entities
{
    class CounterApp
    {
        public CounterApp() { }

        /// <summary>
        /// Get the number of chars in a word or phrase
        /// </summary>
        /// <param name="phrase">A text or word to counter the number of characters</param>
        /// <returns>A list object of CounterClass itens</returns>
        public List<CounterClass> GetNumberOfChars(string phrase)
        {
            List<CounterClass> counters = new List<CounterClass>();

            if (phrase.Trim().Length < 2)
                throw new CounterException("A palavra ou fase deve conter mais de 1 caracter.");

            phrase = phrase.Replace(" ", "").Trim().ToLower();

            for (int i = 0; i < phrase.Length; i++)
            {
                CounterClass counterClass = new CounterClass();
                counterClass.Character = phrase[i];
                counterClass.Count = phrase.Count(x => (x == phrase[i]));

                if (counters.Count(x => (x.Character == phrase[i])) == 0)
                {
                    counters.Add(counterClass);
                }
            }

            return counters;
        }
    }
}
