using System.Collections;

namespace section4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non-Generic-Collection-hashtable
            //// Collection : Built-in DS in C#

            //// Non-Generic-Hashtable : Hashtable

            //Hashtable phoneBook = new Hashtable();
            //phoneBook.Add(1, "Ahmed");
            //phoneBook.Add(2, "Ali");
            //phoneBook.Add(3, "medo");
            //phoneBook.Add(4, "moly");
            //// can't accept null as key and must be unique
            ////phoneBook.Add(null, "moly");

            //// print all keys
            //foreach (var item in phoneBook.Keys)
            //{
            //    Console.WriteLine(item);
            //}

            //// print all values
            //foreach (var item in phoneBook.Values)
            //{
            //    Console.WriteLine(item);
            //}
            //// indexer in hashtable do all of this(set,get,update and insert)
            //phoneBook[5] = "booo";

            //Console.WriteLine(phoneBook.IsFixedSize);
            //Console.WriteLine(phoneBook.IsReadOnly);
            //// DictionaryEntry like bucket but not private so we can use it
            //foreach (DictionaryEntry item in phoneBook)
            //{
            //    Console.WriteLine(item);
            //}
            //// didn't take null
            //phoneBook.Remove(null);
            //// clear all phonebook
            //phoneBook.Clear();

            //// return counts of phonebook
            //Console.WriteLine(phoneBook.Count);

            //// return true or false
            //Console.WriteLine(phoneBook.ContainsValue("booo"));
            //Console.WriteLine(phoneBook.ContainsKey(1));
            //Console.WriteLine(phoneBook.Contains("booo"));

            #endregion
        }
    }
}
