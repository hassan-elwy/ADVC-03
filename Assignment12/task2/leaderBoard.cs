using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12.task2
{
    public class leaderBoard
    {
        Dictionary<int, string> names=new Dictionary<int, string>();

        public void AddNameToDictionary(int value,string name)
        {
            names.Add(value,name);
        }

        public void PrintAllEntries()
        {

            Console.WriteLine("Enteries");
                var keys = names.Keys.Order();
                foreach(var key in keys)
                {
                Console.WriteLine($"{key}:{names[key]}");
                }
            
        }

        public bool checkValueByKey(int key)
        {
            Console.WriteLine("Check keys:" + key);  
            if( names.TryGetValue(key, out string value))
            {
                Console.WriteLine("Found");
                Console.WriteLine("Values"+value);
                return true;
            }
            else {
                Console.WriteLine("NOt Found");
                return false; }
        }

        public bool checkValueByIndex(int index)
        {
            Console.WriteLine("Check Index of :" + (index+1));
            var keys = names.Keys;


            if (names.TryGetValue(keys.ElementAt(index), out string value))
            {
                Console.WriteLine("Found");

                Console.WriteLine("keys: "+keys.ElementAt(index));
                Console.WriteLine("Values:"+value);
                return true;
            }
            else
            {
                Console.WriteLine("NOt Found");
                return false;
            }

        }

        public bool RemovePlayer(int key)
        {
            Console.WriteLine("Removing key: " + key);
           return names.Remove(key);

        }


    }
}
