using System.Collections;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            //List<int> grades = new() { 85, 92, 78, 95, 88, 70, 100, 65 };
            //Console.WriteLine($"collection Count:{grades.Count}");
            //Console.WriteLine($"collection first element:{grades[0]}");
            //Console.WriteLine($"collection last element:{grades[^1]}");
            //grades.Sort();
            //Helper.PrintList("Sort the grades ascending", grades);
            //Console.WriteLine($"first grade above 90:{grades.Find(g=>g>90)}");
            //Console.WriteLine($"all grade below 75:{grades.FindAll(g => g < 75)}");
            //Console.WriteLine($"removeall grade below 75:{grades.RemoveAll(g => g < 75)}");
            //Console.WriteLine($"any grade equals 100:{grades.Exists(g => g ==100)}");
            //grades.ConvertAll(g=>g.ToString());
            //Helper.PrintList("grade becomes Grade: X", grades);
            #endregion

            #region Exercise 2: Leaderboard
            //SortedList<int, string> score = new()
            //{
            //   { 500, "Ahmed" },
            //   { 200, "Sara" },
            //   { 800, "Ali" },
            //   { 350, "Mona" }
            //};

            //foreach (var item in score)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"first key :{score.Keys[0]}");
            //Console.WriteLine($"first value :{score.Values[0]}");
            //if (score.ContainsKey(500))
            //{
            //    Console.WriteLine($"score 500 exists");
            //}
            //else
            //{
            //    Console.WriteLine($"not found");
            //}
            //if (score.TryGetValue(999,out string svalue))
            //{
            //    Console.WriteLine($"the player with score 999 is :{svalue}");
            //}
            //else
            //{
            //    Console.WriteLine($"the player with score 999 is not exist");
            //}
            //score.Remove(200);
            //foreach (var item in score)
            //{
            //    Console.WriteLine($"print the updated list:{item}");
            //}
            #endregion

            #region Exercise 3: Phone Book
            //Dictionary<string, string> phonebook = new()
            //{
            //    { "Bob", "01011111111" },
            //    { "Steve", "01022222222" },
            //    { "Asya", "01033333333" },
            //    { "Erten", "01044444444" }
            //};

            //phonebook["Maher"] = "01000254789";
            //try { 
            //    phonebook.Add("Bob", "0114798782"); 
            //} 
            //catch (Exception ex) { 
            //    Console.WriteLine(ex.Message);
            //}

            //bool result = phonebook.TryAdd("Kenan", "0103657844554");
            //Console.WriteLine(result);

            //Console.WriteLine($"contact with key is exsist? : {phonebook.ContainsKey("Mary")}");

            //if (phonebook.TryGetValue("Diana", out string svalue))
            //{
            //    Console.WriteLine($"the phonebook has value for this key :{svalue}");
            //}
            //else
            //{
            //    Console.WriteLine($"the phonebook  key is not exist");
            //}
            //Console.WriteLine("all keys in phonebook:");
            //foreach (var item in phonebook.Keys)
            //{

            //    Console.Write(item+',');
            //}
            //Console.WriteLine();
            //Console.WriteLine("all values in phonebook:");
            //foreach (var item in phonebook.Values)
            //{

            //    Console.Write(item + ',');
            //}
            #endregion

            #region Exercise 4: Unique Email Validator
            //HashSet<string> emails = new(StringComparer.OrdinalIgnoreCase)
            //{
            //    "ahmed@test.com",
            //    "AHMED@test.com",
            //    "sara@test.com", 
            //    "Sara@Test.Com"
            //};

            //Console.WriteLine($"hashset Count:{emails.Count}");

            //HashSet<int> SetA = [1, 2, 3, 4, 5];
            //HashSet<int> SetB = [4, 5, 6, 7, 8];
            //HashSet<int> newunion = new(SetA);
            //newunion.UnionWith(SetB);
            //Helper.PrintHashSet("A Union B", newunion);

            //HashSet<int> newintersect = new(SetA);
            //newintersect.IntersectWith(SetB);
            //Helper.PrintHashSet("A Intersect B", newintersect);

            //HashSet<int> newexcept = new(SetA);
            //newexcept.ExceptWith(SetB);
            //Helper.PrintHashSet("A Except B", newexcept);

            //var newset = new HashSet<int>() { 1, 2 };
            //Console.WriteLine(newset.IsSubsetOf(SetA));
            #endregion

            #region Exercise 5: Print Queue Simulator
            //Queue<string> printerqueue = new();
            //printerqueue.Enqueue("Report.pdf");
            //printerqueue.Enqueue("Invoice.pdf");
            //printerqueue.Enqueue("Letter.docx");
            //printerqueue.Enqueue("Resume.pdf");
            //printerqueue.Enqueue("Photo.jpg");
            //Console.WriteLine($"queue count :{printerqueue.Count()}");
            //Console.WriteLine($"queue contents:");
            //foreach (var item in printerqueue)
            //{
            //    Console.WriteLine(item);
            //}

            //string nextelemenent = printerqueue.Peek();
            //Console.WriteLine($"document will print next {nextelemenent}");

            //for (int i = printerqueue.Count; i > 0; i--)
            //{
            //    string current = printerqueue.Dequeue();
            //    Console.WriteLine($"Printing: {current}");
            //}

            //bool success = printerqueue.TryDequeue(out string result);
            //if (success==true)
            //{
            //    Console.WriteLine($"Dequeued: {result}");
            //}
            //else
            //{
            //    Console.WriteLine("nothing to dequeue.");
            //}
            #endregion

            #region Exercise 6: Browser History (Undo)
            //Stack<string> browserhistory = new();
            //browserhistory.Push("google.com");
            //browserhistory.Push("github.com");
            //browserhistory.Push("stackoverflow.com");
            //browserhistory.Push("youtube.com");
            //browserhistory.Push("claude.ai");

            //string topofstack = browserhistory.Peek();
            //Console.WriteLine($"the current page {topofstack}");

            //for (int i = 0; i <3; i++)
            //{
            //    string current = browserhistory.Pop();
            //    Console.WriteLine($"Printing: {current}");
            //}

            //Console.WriteLine($"Current page after going back: {browserhistory.Peek()}");

            //bool success = browserhistory.TryPop(out string result);
            //if (success == true)
            //{
            //    Console.WriteLine($"pop: {result}");
            //}
            //else
            //{
            //    Console.WriteLine("nothing to pop.");
            //}
            #endregion
        }
    }
}
