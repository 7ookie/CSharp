using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sumPositiveDigits
{
    class sumPositiveDigits
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 5, 6, 7, 8 };
            int[] array = { 5, 5, 5, 5 };
            Console.WriteLine(SumArrays(arr, array));
        }
        static string SumArrays(int[] arrOne, int[] arrTwo)
        {
            List<int> smallArray = new List<int>();
            List<int> bigArray = new List<int>();
            if (arrOne.Length > arrTwo.Length)
            {
                bigArray.AddRange(arrOne);
                smallArray.AddRange(arrTwo);
            }
            else
            {
                smallArray.AddRange(arrOne);
                bigArray.AddRange(arrTwo);
            }
            int sum = 0;
            int carry = 0;
            int lenghtMin = smallArray.Count;
            int lenghtMax = bigArray.Count;
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < lenghtMin; i++)
            {
                sum = smallArray[i] + bigArray[i] + carry;
                if (sum >= 10)
                {
                    carry = 1;
                    sum = sum % 10;
                    result.Append(sum);
                }
                else
                {
                    result.Append(sum);
                    carry = 0;
                }
            }
            for (int z = lenghtMin; z < lenghtMax; z++)
            {
                sum = bigArray[z] + carry;
                if (sum >= 10)
                {
                    carry = 1;
                    sum = sum % 10;
                    result.Append(sum);
                }
                else
                {
                    result.Append(sum);
                    carry = 0;
                }
            }
            if (carry == 1)
            {
                result.Append(1);
            }
            char[] reversed = result.ToString().ToCharArray();
            result.Clear();
            for (int i = reversed.Length - 1; i >= 0; i--)
            {
                result = result.Append(reversed[i]);
            }
            return result.ToString();
        }
    }
}
