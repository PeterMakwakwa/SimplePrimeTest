using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyPrimeNumbers
{
    public class PrimeNumbers : IPrimeNumbers
    {
        public void PrimeNumer(int range)
        {
            int count = 0;
            //List<int> listPrimeNumber = new List<int>();

            for (int i = 1; i <= range; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j != 0)
                    {
                        count += 1;
                    }
                }
                if (count == (i - 2))
                {
                    //listPrimeNumber.Add(count);
                    Console.Write(i + "\t");
                }

                count = 0;
            }
            //return listPrimeNumber;
        }
    }
}
