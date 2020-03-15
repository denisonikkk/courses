using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace courses2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibon f = new Fibon();
            Fact fac = new Fact();
            chet_nechet ch = new chet_nechet();
            steps st = new steps();
            while (true)
            {
                Console.WriteLine("Введите номер задания, которое нужно запустить(1-4)!");
                int number_of_task = int.Parse(Console.ReadLine());
                switch (number_of_task)
                {
                    case 1:
                        f.resh();
                        Console.WriteLine("Введите что-то чтобы продолжить!");
                        Console.ReadLine();
                        break;
                    case 2:
                        fac.resh();
                        Console.WriteLine("Введите что-то чтобы продолжить!");
                        Console.ReadLine();
                        break;
                    case 3:
                        st.resh();
                        Console.WriteLine("Введите что-то чтобы продолжить!");
                        Console.ReadLine();
                        break;
                    case 4:
                        ch.resh();
                        Console.WriteLine("Введите что-то чтобы продолжить!");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
        }
    }
}
