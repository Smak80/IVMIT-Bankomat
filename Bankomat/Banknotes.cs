using System;
using System.Collections.Generic;
using System.Text;

namespace Bankomat
{
    class Banknotes
    {
        private int[] nom;

        public Banknotes()
        {
            input();
        }

        private void input()
        {
            Console.WriteLine("Введите возможные номиналы купюр:");
            var inp = Console.ReadLine();
            var sn = inp.Split(" ");
            var i = 0;
            nom = new int[sn.Length];
            foreach (var n in sn)
            {
                nom[i] = int.Parse(n);
                i++;
            }
        }

        private int GetMinCountFor(int sm, int startIndex)
        {
            var sm1 = sm;
            if (sm <= 0) return 0;
            var maxcb = 0;
            maxcb = sm / nom[startIndex];
            for (var i = 0; i <= maxcb; i++)
            {
                var cb = maxcb - i;
                sm = sm1 % nom[startIndex] + i * nom[startIndex];

            }
        }
        public int GetMinCountFor(int s)
        {
            //Сортировка массива номиналов

        }
        public int get(int index)
        {
            if (index >= 0 && index < nom.Length)
                return nom[index];
            return 0;
        }
    }
}
