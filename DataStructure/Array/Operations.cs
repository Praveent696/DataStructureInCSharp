using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Array
{
    public class Operations
    {
        public static T[] insertAtIndex<T>(T[] array,int index,T value) 
        {
            T[] newArray = array;
            System.Array.Resize(ref newArray,newArray.Length+1);

            int j = index;
            int n = array.Length;
            while(j<=n)
            {
                newArray[n] = newArray[n-1];
                n=n-1;
            }
            newArray[index] = value;
            return newArray.ToArray();
        }

        public static T[] removeAtIndex<T>(T[] array, int index)
        {
            T[] newArray = array;
            int j = index;
            int n = array.Length-1;
            while (j < n)
            {
                newArray[j]=newArray[j+1];
                j = j + 1;
            }
            System.Array.Resize(ref newArray, newArray.Length - 1);
            return newArray.ToArray();
        }

        public static T[] updateAtIndex<T>(T[] array, int index, T newValue)
        {
            T[] newArray = array;
            newArray[index - 1] = newValue;
            return newArray;
        }

        public static T getValueAtIndex<T>(T[] array,int index)
        {
            return array[index];
        }

        public static int[] searchInArray<T>(T[] array, T value)
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < array.Length;i++ )
            {
                if (array[i].ToString() == value.ToString())
                {
                    indexes.Add(i);
                }
            }
            return indexes.ToArray();
        }

        public static void printArray<T>(T[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine();
        }


    }
}
