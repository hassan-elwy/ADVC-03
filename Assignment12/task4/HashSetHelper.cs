namespace Assignment12.task4
{
    public static class HashSetHelper<T>
    {
        public static void ShowUnion(HashSet<T> setA, HashSet<T> setB)
        {
            HashSet<T> union = new HashSet<T>();
            union = setA;
            union.UnionWith(setB);
            Console.Write("Union:");

            if (union.Count > 0)
            {

                foreach (T value in union)
                    Console.Write(" " + value + " ");
            }
            else { Console.WriteLine("no correlation"); }

            Console.WriteLine();

        }

        public static void ShowIntersection(HashSet<T> setA, HashSet<T> setB)
        {
            HashSet<T> intersect = new HashSet<T>();
            intersect = setA;
            intersect.IntersectWith(setB);
            Console.Write("intersect: ");

            if (intersect.Count > 0)
            {

                foreach (T value in intersect)
                Console.Write(" " + value + " ");
            }
            else { Console.WriteLine("no correlation"); }

                Console.WriteLine();
        }

        public static void ShowExceptWith(HashSet<T> setA, HashSet<T> setB)
        {
            HashSet<T> except = new HashSet<T>();
            except = setA;
            except.ExceptWith(setB);
            Console.Write("ExceptBy:");

            if (except.Count > 0)
            {

                foreach (T value in except)
                    Console.Write(" " + value + " ");
            }
            else { Console.WriteLine("no correlation"); }


            Console.WriteLine();

        }

    }
}
