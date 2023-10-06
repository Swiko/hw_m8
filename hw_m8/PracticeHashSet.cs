using System;
using System.Collections.Generic;

namespace hw_m8
{
    internal class PracticeHashSet
    {

        private HashSet<int> HSet {  get; set; }

        private Random Rand { get; }

        public PracticeHashSet()
        {
            HSet = new HashSet<int>();
            Rand = new Random();
            HashSetAutoFilling();
            PrintHashSet();
            Console.ReadKey();
        }

        private void PrintHashSet()
        {

            Console.Write("Result: ");
            
            foreach (int i in HSet)
            {
                
                Console.Write($"{i} ");
            }

        }

        private void HashSetAutoFilling()
        {

            for(int i = 0; i < 10; i++)
            {
                int set = Rand.Next(10);
                if (!HSet.Contains(set))
                {
                    HSet.Add(set);
                    
                    Console.WriteLine($"Value saved: {set}");
                }
                else
                {
                    Console.WriteLine($"The value is already present in the collection: {set}");
                }
            }

        }


    }
}
