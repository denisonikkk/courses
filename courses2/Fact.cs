using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courses2
{
    class Fact
    {
        private int factor(int n) {
            if (n == 1)
            {
                return n;
            }
            else {
                return n * factor(n - 1);
            }
        }
        public void resh()
        {
            Console.WriteLine("Введите число, для которого нужно вычеслить факториал.");
            int n = int.Parse(Console.ReadLine());
            int rezult = factor(n);
            Console.WriteLine(rezult);
            
        }

    }
}
