using System;
using System.Collections.Generic;

namespace hw_m8
{
    internal class PracticeList
    {

        private List<int> List { get; set; }

        private Random Rnd { get; }

        public PracticeList()
        {
            List = new List<int>();
            Rnd = new Random();
            FillingList();
            PrintList();
            Console.WriteLine($"\nList is full. Amount: {List.Count}");
            FilteringList();
            PrintList();
            Console.WriteLine($"\nList filtered. Amount: {List.Count}");
            Console.ReadKey();
        }

        private void FillingList ()
        {
            for (int i = 0; i < 100; i++)
            {
                List.Add(Rnd.Next(101));
            }
        }

        private void PrintList()
        {
            int newLine = 0;
            foreach(int i in List)
            {
                if(newLine % 5 == 0) Console.WriteLine();
                Console.Write($"{i} \t");
                newLine++;
            }
        }

        private void FilteringList ()
        {
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i] >= 25 && List[i] <= 50)
                {
                    List.RemoveAt(i);
                    i--;
                }
            }
        }

    }
}
