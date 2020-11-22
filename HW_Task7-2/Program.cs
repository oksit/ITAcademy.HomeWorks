using System;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

namespace HW_Task7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some string");

            string userString = Console.ReadLine();

            DeleteMaxWord(userString);
            ReplaceMaxMinWord(userString);
            CountLetters(userString);
            SortArrayOfString(userString);   
        }
        #region DeleteMaxWord
        static void DeleteMaxWord(string str)
        {
            string[] array1 = str.Split(' ');

            int count = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i].Length >= count) { count = array1[i].Length; }
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i].Length == count) { array1[i] = ""; }
            }

            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        #endregion

        #region ReplaceMaxMinWord
        static void ReplaceMaxMinWord(string str2)
        {
            string[] array2 = str2.Split(' ');

            int maxCount = 0;
            string maxWord = "";
            string minWord = "";
            int maxIndex = 0;

            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i].Length >= maxCount) { maxCount = array2[i].Length; maxWord = array2[i]; maxIndex = i; }
            }
            //Console.WriteLine("maxword " + maxWord + " maxIndex "+ maxIndex);

            int minCount = maxCount;
            int minIndex = 0;

            for (int i = 0; i < array2.Length; i++)
            {

                if ((array2[i].Length >= 1) & (array2[i].Length <= minCount))
                { minCount = array2[i].Length; minWord = array2[i]; minIndex = i; }

            }

            //Console.WriteLine("minword " + minWord + " minIndex " + minIndex);

            array2[maxIndex] = minWord;

            array2[minIndex] = maxWord;

            Console.WriteLine();

            Console.WriteLine("After replace:\n");

            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        #endregion

        #region CountLetters
        static void CountLetters(string str3)
        {
            int countLetters = 0;
            for (int i = 0; i < str3.Length; i++)
            {
                if (char.IsLetter(str3[i])) countLetters++;
            }
            Console.WriteLine($"Количество букв в строке = {countLetters}");

            int countSign = 0;
            for (int i = 0; i < str3.Length; i++)
            {
                if (char.IsPunctuation(str3[i])) countSign++;
            }
            Console.WriteLine($"Количество знаков препинания в строке = {countSign}");
        }
        #endregion

        #region SortArrayOfString
        static void SortArrayOfString(string str4)
        {
            string[] array4 = str4.Split(' ');
            int size = array4.Length;

            for (int i = 0; i < size; i++)
            {
                for (int k = i + 1; k < size; k++)
                {
                    if (array4[i].Length > array4[k].Length)
                    {
                        string str1 = " ";
                        str1 = array4[i];
                        array4[i] = array4[k];
                        array4[k] = str1;
                    }
                }
            }
            Array.Reverse(array4);

            foreach (string x in array4)
            {
                Console.WriteLine(x);
            }
        }
        #endregion
    }
}
