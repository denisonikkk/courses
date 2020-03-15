using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courses2
{
    class Fibon
    {
        public void resh() {
            int a = 0, b = 1;
            Console.WriteLine("Введите номер числа Фибоначчи, которое нужно вывести.");
            int number_of_chlen= int.Parse(Console.ReadLine());
            for (int i = 0; i< number_of_chlen-2; i++) {
                if (i % 2 == 0) {
                    a = a + b;
                }
                if (i % 2 != 0) {
                    b = b + a;
                }
            }
            if (number_of_chlen % 2 == 1)
            {
                Console.WriteLine(a);
            }
            else {
                Console.WriteLine(b);
            }
            
        }
    }
}
