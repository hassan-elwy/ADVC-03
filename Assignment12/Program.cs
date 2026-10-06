using Assignment12.task1;
using Assignment12.task2;

namespace Assignment12
{
    internal class Program
    {
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
             List<int> grades = new List<int>() {85, 92, 78, 95, 88, 70, 100, 65};
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
            task2();
        }
    }
}
