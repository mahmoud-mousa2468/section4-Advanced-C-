using section4.YouTube;

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
            #region Event
            // Delegate : C# Feature

            // C# Pure OOP

            // Event : 
            // 1- Functional Programming
            // 2- Event-Driven Programming
            #region EX01
            //Ball ball = new Ball();


            //Player P01 = new Player() { Name = "Messi", TeamName = "Miami" };
            //Player P02 = new Player() { Name = "Alba", TeamName = "Miami" };
            //Player P03 = new Player() { Name = "Pedri", TeamName = "Barcelona" };
            //Player P04 = new Player() { Name = "Gavi", TeamName = "Barcelona" };
            //Player P05 = new Player() { Name = "Salah", TeamName = "Barcelona" };

            //Refree R01 = new Refree() { Name = "Ibrahim Nour El-Din" };
            //Coach C01 = new Coach() { Name = "Mahmoud", TeamName = "Miami" };
            //Coach C02 = new Coach() { Name = "Ali", TeamName = "Barcelona" };

            //Using Delegate
            //ball.BAllLocationChanged = P01.Run;
            //ball.BAllLocationChanged += P02.Run;
            //ball.BAllLocationChanged += P03.Run;
            //ball.BAllLocationChanged += P04.Run;
            //ball.BAllLocationChanged += R01.Look;
            //ball.BAllLocationChanged += P04.Run;
            //ball.BAllLocationChanged += C01.Order;
            //ball.BAllLocationChanged += C02.Order;





            //Using Event
            //ball.BAllLocationChanged += P01.Run;
            //ball.BAllLocationChanged += P02.Run;
            //ball.BAllLocationChanged += P03.Run;
            //ball.BAllLocationChanged += P04.Run;
            //ball.BAllLocationChanged += R01.Look;
            //ball.BAllLocationChanged += C01.Order;
            //ball.BAllLocationChanged += C02.Order;
            //ball.Location = new Location() { X = 1, Y = 1, Z = 1 };
            //Console.WriteLine();

            //ball.BAllLocationChanged -= P04.Run;
            //ball.BAllLocationChanged += P05.Run;
            //ball.Location = new Location() { X = 2, Y = 1, Z = 1 };
            #endregion
            #region Ex02
            //Channel channel = new Channel() { Title = "ABC" };
            //channel.AddVideo(new Video() { Title = "Title01", Description = "Des 01" });
            //Subscriber S01 = new Subscriber() { Name = "Ahmed" };
            //Subscriber S02 = new Subscriber() { Name = "Ali" };
            //Subscriber S03 = new Subscriber() { Name = "Mona" };
            //Subscriber S04 = new Subscriber() { Name = "Mohamed" };
            //Subscriber S05 = new Subscriber() { Name = "Mariam" };


            //channel.Uploaded += S01.Notify;
            //channel.Uploaded += S02.Notify;
            //channel.Uploaded += S03.Notify;
            //channel.Uploaded += S04.Notify;
            //channel.AddVideo(new Video() { Title = "Title02", Description = "Des 02" });


            //Console.WriteLine("After Ahmed UnSubscribe");
            //channel.Uploaded -= S01.Notify;
            //channel.Uploaded += S05.Notify;
            //channel.AddVideo(new Video() { Title = "Title03", Description = "Des 03" });

            #endregion
            #endregion


        }
    }
}
