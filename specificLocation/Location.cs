using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specificLocation
{
    class Location
    {
        int[] data = new int[6];
        int insert,location;
        int temp = 0;

        public void insertingElement()
        {
            Console.WriteLine("Insert elemnt in array  ");
            for (int i = 0; i < data.Length-2; i++)
            {
                data[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(data[i]);
            }
            Console.WriteLine("Print Array");

            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }

            Console.WriteLine("In which location u want to insert new element");
            location = Convert.ToInt32(Console.ReadLine());
            location = location - 1;
            if (location>=0||location>=1&& location<=5)
            {
                temp = data[data.Length - 2];
                Console.WriteLine("Insert Element which you want to insert in location"+data[location]);
                for (int i = data.Length-2; i > location; i--)
                {
                    data[i] = data[i - 1];
                }
                insert = Convert.ToInt32(Console.ReadLine());
                data[location] = insert;
            }

            Console.WriteLine("After insertion at Specific Location Array becomes");
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }

        }

    }
}
