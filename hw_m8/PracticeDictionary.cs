using System;
using System.Collections.Generic;

namespace hw_m8
{
    internal class PracticeDictionary
    {

        private Dictionary<string, string> Dict { get; set; }

        private Random Rand { get; }

        public PracticeDictionary()
        {
            Dict = new Dictionary<string, string>();
            Rand = new Random();
            ControlElements();
        }

        private void GetValueWithKey()
        {

            Console.WriteLine("Input key");
            string key = Console.ReadLine();

            if (Dict.TryGetValue(key, out var value))
            {
                Console.Write(value);
            }
            else
            {
                Console.WriteLine($"KeyNotFounded {key}");
            }
            
             ControlElements();
            
        }

        private void PrintDictionary()
        {
            foreach(KeyValuePair<string, string> kvp in Dict)
            {
                Console.WriteLine(kvp);
            }

            ControlElements();
        }

        private void DictionaryManualFilling()
        {
            
            Console.WriteLine("Input key (phone number)");
            string key = Console.ReadLine();
            Console.WriteLine("Input value (phone member)");
            string value = Console.ReadLine();

            if(key == string.Empty || value == string.Empty)
            {
                ControlElements();
            }

            Dict.Add(key, value);
            DictionaryManualFilling();

        }

        private void DictianoryAutoFilling()
        {
            
            string[] phoneContacts = { "Jane", "Jade", "Mike", "Peter", "Sam", "Yolo", "Boris" };

            for(int i = 0; i < 10; i++)
            {
                int phoneNumber = Rand.Next(1000000, 9999999);
                Dict.Add(phoneNumber.ToString("###-##-##"), phoneContacts[Rand.Next(phoneContacts.Length)]);
            }

            ControlElements();

        }

        public void ControlElements()
        {

            Console.WriteLine("\nInput 1 - for autofill dictionary" +
                              "\nInput 2 - for fill in manually" +
                              "\nInput 3 - for print dictionary" +
                              "\nInput 4 - for find value with key");

            int count = int.Parse(Console.ReadLine());

            switch ( count )
            {
                case 1: DictianoryAutoFilling();
                    Console.WriteLine("Autofilling complete");
                    break;
                case 2: DictionaryManualFilling();
                    break;
                case 3: PrintDictionary();
                    break;
                case 4: GetValueWithKey();
                    break;
            }

        }
    }
}