using System;
namespace Bankomat
{
    class Program
    {

        static void Main(string[] args)
        {
            var nm = new Banknotes();
            Console.WriteLine("Введите сумму:");
            var inp = Console.ReadLine();
            var s = int.Parse(inp);
            var res = nm.GetMinCountFor(s);
            if (res == 0)
            {
                Console.WriteLine("Сумму выдать не удалось :(");
            }
            else
            {
                Console.WriteLine("Необходимо {0} банкнот", res);
            }
        }
    }
}
