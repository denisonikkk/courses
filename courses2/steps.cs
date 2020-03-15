using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courses2
{
    enum Days {
        Понедельник,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
    class steps
    {
        
        
        
        public void resh() {
            Dictionary<string, int> d = new Dictionary<string, int>();
            Console.WriteLine("Введите количество шагов в каждый день недели.");
            foreach (string res in Enum.GetNames(typeof(Days))) {
                int st = int.Parse(Console.ReadLine());
                d.Add(res, st);
            }

            var StepsGroup = from a in d
                             group a by d.Values;
            foreach (var dic in StepsGroup)
            {
                foreach (KeyValuePair<string, int> keyValue in dic)
                    Console.WriteLine(keyValue.Key+" " +keyValue.Value);
                
            }
            
        }
    }
}
