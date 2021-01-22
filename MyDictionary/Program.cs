using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("2018510023", "Özcan Elmacı");
            dictionary.Add("1234567891", "İsim1 Soyisim1");
            dictionary.Add("2345678912", "İsim2 Soyisim2");

            Console.WriteLine(dictionary.Count);


            //MyDictionary 
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();

            myDictionary.Add("2018510023", "Özcan Elmacı");
            myDictionary.Add("1234567891", "İsim1 Soyisim1");
            myDictionary.Add("2345678912", "İsim2 Soyisim2");
            myDictionary.Add("2345678912", "İsim2 Soyisim2"); //this is for trying whether MyDictionary allows to add the same Key or not.

            Console.WriteLine(myDictionary.Count);
        }
    }
}
