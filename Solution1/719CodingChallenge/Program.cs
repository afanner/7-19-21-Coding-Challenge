using System;
using System.Collections.Generic;
using System.Linq;

namespace _719CodingChallenge
{
    class Program
    {
        
        static int overallLength;
        static void PrintPermutation(List<int> arr, List<int> iterList)
        {
            List<int> intList = iterList.ToList();
            foreach (int i in arr)
            {
                intList.Add(i);
                List<int> arrCopy = arr.ToList();
                arrCopy.Remove(i);
                PrintPermutation(arrCopy, intList);
                intList.Remove(i);
            }
            List<string> strings = new List<string>();
            foreach (int l in intList) strings.Add(l.ToString());
            if(strings.Count == overallLength) Console.WriteLine(string.Join(' ', strings));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Print your input as space seperated, unique integers");
            string input = Console.ReadLine();
            string[] numbersAsStrings = input.Split(' ');
            int[] numberS = new int[numbersAsStrings.Length];
            for(int i = 0; i < numbersAsStrings.Length; i++)
            {
                numberS[i] = Int32.Parse(numbersAsStrings[i]);
            }
            overallLength = numberS.Length;
            PrintPermutation(new List<int>(numberS), new List<int>());
            
        }
    }
}
