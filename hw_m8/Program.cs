using System;

namespace hw_m8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input checking task: ");
            int count = int.Parse(Console.ReadLine());

            switch ( count )
            {
                case 1:
                    PracticeList taskList = new PracticeList();
                    break;
                case 2:
                    PracticeDictionary taskDictionary = new PracticeDictionary();
                    break;
                case 3:
                    PracticeHashSet taskHashSet = new PracticeHashSet();
                    break;
                case 4:PracticeXML taskXML = new PracticeXML();
                    break;
            }
        }
    }
}
