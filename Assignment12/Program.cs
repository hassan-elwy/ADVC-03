using Assignment12.task1;

namespace Assignment12
{
    internal class Program
    {

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
            task1();
        }
    }
}
