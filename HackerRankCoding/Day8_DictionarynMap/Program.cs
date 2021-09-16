using System;
using System.Collections;

namespace Day8_DictionarynMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable phonebook = new Hashtable();
            Console.WriteLine("Enter no of input values:");
                int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                
                Console.Write("Enetr Key Value Pair seperated by space:");
                string keyvalpai = Console.ReadLine();
                string[] pairs = keyvalpai.Split(' ');

                string key = pairs[0];
                string val = pairs[1];

                phonebook.Add(key, val);
            }

            //phonebook.Add("Pooja", "2067125534");
            //phonebook.Add("Tushar", "4255535032");

            ICollection keys = phonebook.Keys;
            foreach (string key in keys)
            {
                Console.WriteLine(key);

            }

            Console.WriteLine("Enter the key whose value you want to print:");
            string querykey = Console.ReadLine();

            bool isKeyPresent=phonebook.ContainsKey(querykey);
            if(isKeyPresent==true)
            {
                var mykeys = phonebook.Keys;
                foreach(string key in mykeys)
                {
                    if(key == querykey)
                    {
                        Console.WriteLine(key + "=" + phonebook[querykey]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Not found");
            }




            Console.ReadLine();

        }
    }
}
