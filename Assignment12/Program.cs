using Assignment12.task1;
using Assignment12.task2;
using Assignment12.task4;
using Assignment12.task5;

namespace Assignment12
{
    internal class Program
    {
        public static void task6()
        {
            Stack<string>stack=new Stack<string>();

            stack.Push("google.com");
            stack.Push("github.com");
            stack.Push("stackoverflow.com");
            stack.Push("youtube.com");
            stack.Push("claude.ai");

            Console.WriteLine("============peek===========");
            Console.WriteLine("Current page:"+stack.Peek());

            Console.WriteLine("============leaving pages===========");
            Console.WriteLine("Leaving page: "+stack.Pop()); 
            Console.WriteLine("Leaving page: "+stack.Pop()); 
            Console.WriteLine("Leaving page: "+stack.Pop()); 

            Console.WriteLine("============current page===========");
            Console.WriteLine("Current page:"+stack.Peek());

            Console.WriteLine("====popping to empty=====");
            stack.Pop();
            stack.Pop();

            Console.Write("stack count:");
            Console.WriteLine(stack.Count);

            Console.WriteLine("======Executing TryPop:========");

            stack.TryPop(out string res);
            

                Console.WriteLine(res is not null?res:"result is null" );
            

            
            
        }
        public static void task5()
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Report.pdf");
            queue.Enqueue("Invoice.pdf");
            queue.Enqueue("Letter.docx");
            queue.Enqueue("Resume.pdf");
            queue.Enqueue("Photo.jpg");

            QueueHelper<string>.printContentAndCount(queue);

            QueueHelper<string>.PeekItem(queue);

            QueueHelper<String>.Dequeue(queue);
            QueueHelper<String>.Dequeue(queue);
            QueueHelper<String>.Dequeue(queue);
            QueueHelper<String>.Dequeue(queue);
            QueueHelper<String>.Dequeue(queue);


            QueueHelper<String>.Dequeue(queue);
        }
        public static void task4()
        {
            HashSet<string> emails =
            new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            emails.Add("ahmed@test.com");
            emails.Add("AHMED@test.com");
            emails.Add("sara@test.com");
            emails.Add("Sara@Test.Com");

            Console.WriteLine("========Counting Emails========");
            //2 email counted because 2 emails are repeated with different case and case no longer make a difference 
            Console.WriteLine(emails.Count());


            Console.WriteLine("================");

            HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            HashSetHelper<int>.ShowUnion(setA, setB);
            HashSetHelper<int>.ShowIntersection(setA, setB);
            HashSetHelper<int>.ShowExceptWith(setA, setB);

            Console.WriteLine("========IsSubsetOf========");

            Console.WriteLine(setA.IsSubsetOf(new int[] { 1, 2 }));

        }
        public static void task3()
        {
            Dictionary<string, int> Contacts = new Dictionary<string, int>();

            Contacts["ahmed"] = 0100123456;
            Contacts["bassem"] = 0110234567;
            Contacts["kamel"] = 0120345678;
            Contacts["hassan"] = 0120456789;
            Console.WriteLine("=============Adding duplicate============");
            try
            {

                Contacts.Add("hassan", 01001777772);
            }
            catch (Exception e) { Console.WriteLine(e); }

            Console.WriteLine("==========Try adding duplicate===============");

            Console.WriteLine(Contacts.TryAdd("hassan", 01001777772));


            Console.WriteLine("==========Accessing non existant key===============");
            try
            {

                Console.WriteLine(Contacts["gamal"]);
            }
            catch (Exception e) { Console.WriteLine(e); }

            Console.WriteLine("============view all keys&values=============");
            var keys = Contacts.Keys;

            var values = Contacts.Values;

            Console.WriteLine("keys");
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("values");

            foreach (var value in values)
            {
                Console.WriteLine(value);
            }

        }
        public static void task2()
        {
            leaderBoard ld = new leaderBoard();

            ld.AddNameToDictionary(500, "Ahmed");
            ld.AddNameToDictionary(200, "Sara");
            ld.AddNameToDictionary(800, "Ali");
            ld.AddNameToDictionary(350, "Mona");

            ld.PrintAllEntries();
            Console.WriteLine("===============================");
            ld.checkValueByIndex(0);
            Console.WriteLine("===============================");
            ld.checkValueByKey(500);
            Console.WriteLine("===============================");
            ld.checkValueByKey(900);

            Console.WriteLine("===============================");
            ld.RemovePlayer(200);

            Console.WriteLine("===============================");
            ld.PrintAllEntries();
            Console.WriteLine("===============================");
        }
        public static void task1()
        {
            List<int> grades = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };
            Console.WriteLine("\nprint all count , find last find");
            CollectionHelper<List<int>, int>.PrintCollection(grades);
            Console.WriteLine(grades.Count);
            Console.WriteLine(grades.ElementAt(0));
            Console.WriteLine(grades.ElementAt(grades.Count - 1));


            Console.WriteLine("\nprint after sorting");
            grades.Sort();
            CollectionHelper<List<int>, int>.PrintCollection(grades);

            Console.WriteLine("\nGet index of first mark > 90");
            Console.WriteLine(CollectionHelper<List<int>, int>.GetFirstHighMark(grades));


            Console.WriteLine("\nGet index of Full marks ");
            CollectionHelper<List<int>, int>.findFullMarks(grades);

            Console.WriteLine(CollectionHelper<List<int>, int>.ConvertIntostring(grades));

        }
        static void Main(string[] args)
        {
            //task1();
            //task2();
            //task3();

            //task4();
            //task5();

            task6();
        }
    }
}
