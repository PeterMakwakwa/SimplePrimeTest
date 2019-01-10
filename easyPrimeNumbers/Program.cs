using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyPrimeNumbers
{
    class Program
    {
        private readonly IPrimeNumbers _primeNumbers;

        public Program(IPrimeNumbers primeNumbers)
        {
            _primeNumbers = primeNumbers;
        }

        static void Main(string[] args)
        {
            Program pp = new Program(new PrimeNumbers());
            pp._primeNumbers.PrimeNumer(100);
            Console.ReadKey();
        }
    }
}
