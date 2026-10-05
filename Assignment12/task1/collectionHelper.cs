using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12.task1
{
    public static class CollectionHelper<T1, T2>
     where T1 : ICollection<T2> where T2 : IComparable
    {
        public static void PrintCollection(T1 collection)
        {
            Console.WriteLine();
            for (int i = 0; i < collection.Count; i++)
            {
                Console.Write(collection.ElementAt(i)+ " ");
            }
            Console.WriteLine();
        }

        public static void RemoveFailure(T1 collection)
        {

            for (int i = 0; i < collection.Count; i++)
            {
                if(collection.ElementAt(i).CompareTo(75)>0 )
                {
                    collection.Remove(collection.ElementAt(i));

                }
            }
        }
        public static int GetFirstHighMark(T1 collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection.ElementAt(i).CompareTo(90) > 0)
                {
                    return i;
                }
            }
            return -1;
        }
        public static void findFullMarks(T1 collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection.ElementAt(i).CompareTo(100) == 0)
                {
                    Console.WriteLine($"Full mark found at :{i + 1}");
                }
            }
        }

        public static String ConvertIntostring(T1 collection)
        {
            string s="";
            for (int i = 0; i < collection.Count; i++)
            {
                s = $"Grades : {collection.ElementAt(i).ToString()}";
            }

            return s;

        }
    }
}
