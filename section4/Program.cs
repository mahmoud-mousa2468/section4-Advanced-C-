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
            #region Generic Collection-Dictionary
            //Dictionary<int, string> phoneBook = new Dictionary<int, string>();

            //phoneBook.Add(1, "mo");
            //phoneBook.Add(2, "bo");
            //phoneBook.Add(3, "oo");
            //// can't accept null
            ////phoneBook.Add(null, "oo");

            //foreach (KeyValuePair<int,string> item in phoneBook)
            //{
            //    Console.WriteLine(item);
            //}
            //// return true or false
            ////var flag = phoneBook.Remove(1);
            //// put the removing value in result variable
            //var flag = phoneBook.Remove(1,out string result);
            //Console.WriteLine(flag);
            //Console.WriteLine(result);

            //phoneBook.TryAdd(1, "co");

            //phoneBook.TryGetValue(1, out string R);
            //Console.WriteLine(R);
            #endregion
            #region Generic Collection-hashset
            // Generic hashTable : hashSet
            // we use it if we want high performance and the data dosen't has keys
            //HashSet<string> names = new HashSet<string>();
            //names.Add("mo");
            //names.Add("bo");
            //names.Add("co");
            //var flag = names.Contains("mo");
            //Console.WriteLine(flag);
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Generic Collection-Sorted DS -SortedDictionary
            // same as Dictionary but sorted so it's complexety will be O(log n)
            //SortedDictionary<int, string> pairs = new SortedDictionary<int, string>();
            //pairs.Add(23, "bo");
            //pairs.Add(20, "co");
            //pairs.Add(10, "mo");
            #endregion
            #region Generic Collection-Sorted DS -SortedList-SortedSet
            ////Sorted list like regular list and dictionary and it's complexity is O(logn)
            //SortedList<int, string> pairs = new SortedList<int, string>();
            ////pairs.SetValueAtIndex(1);

            //// sortedset like hashset in c# 
            ////it's complexity o(1)
            //SortedSet<int> ints = new SortedSet<int>();
            #endregion
        }
    }
}
