using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courses2
{
    class chet_nechet
    {
        public void resh() {
            List<chislo> l = new List<chislo>();
            Console.WriteLine("Введите количество цифр:");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цифры:");
            for (int i = 0; i < size; i++) {
                int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    l.Add(new chislo() { number = a, Chetnoe = true });
                }
                else {
                    l.Add(new chislo() { number=a,Chetnoe = false});
                }
            }
            
            var numberGroups = from chislo in l
                               group chislo by chislo.Chetnoe;
                               
            foreach (IGrouping<bool,chislo> g in numberGroups) {
                if (g.Key == true)
                {
                    Console.WriteLine("Четные:");
                }
                else {
                    Console.WriteLine("Нечетные:");
                }
                foreach (var t in g) {
                    Console.WriteLine(t.number);
                }
            }
            
                                   
                               

        }
    }
}
