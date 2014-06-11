using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumString
{
    class sumString
    { 
        static void Main(string[] args)
        {
            string num = "43 68 9 23 318";
            Console.WriteLine(SumStringMethod(num));
        }
        static int SumStringMethod(string num)
        {
            char[] separators = new char[] {' '};//define what to skip
            string[] splited = num.Split(separators, StringSplitOptions.RemoveEmptyEntries);//split string
            int[] array = new int[splited.Length];//define array lenght
            int sum = 0;
            for (int i = 0; i < splited.Length; i++)
            {
                array[i] = Convert.ToInt32(splited[i]);//convert string array to int array
                sum += array[i];//sum int array elements
            }
            return sum;
        }
    }
}
