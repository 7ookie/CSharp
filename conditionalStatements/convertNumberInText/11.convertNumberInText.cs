using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace convertNumberInText
{
    class convertNumberInText
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer number from 0 to 999.\nnumber = ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 0: Console.Write(" zero "); break;
                case 1: Console.Write(" one "); break;
                case 2: Console.Write(" two "); break;
                case 3: Console.Write(" three "); break;
                case 4: Console.Write(" four "); break;
                case 5: Console.Write(" five "); break;
                case 6: Console.Write(" six "); break;
                case 7: Console.Write(" seven "); break;
                case 8: Console.Write(" eight "); break;
                case 9: Console.Write(" nine "); break;
            }
            switch (num)
            {
                case 20: Console.Write(" twenty "); break;
                case 30: Console.Write(" thirty "); break;
                case 40: Console.Write(" fourty "); break;
                case 50: Console.Write(" fifty "); break;
                case 60: Console.Write(" sixty "); break;
                case 70: Console.Write(" seventy "); break;
                case 80: Console.Write(" eighty "); break;
                case 90: Console.Write(" ninety "); break;
            }

            int hundreds;
            if (num / 100 != 0)
            {
                hundreds = num / 100;
                switch (hundreds)
                {
                    case 1: Console.Write(" one "); break;
                    case 2: Console.Write(" two "); break;
                    case 3: Console.Write(" three "); break;
                    case 4: Console.Write(" four "); break;
                    case 5: Console.Write(" five "); break;
                    case 6: Console.Write(" six "); break;
                    case 7: Console.Write(" seven "); break;
                    case 8: Console.Write(" eight "); break;
                    case 9: Console.Write(" nine "); break;
                }
                Console.Write(" hundred and ");
                double temp;
                int tens;
                int s;
                if (num / 10 != 0)
                {
                    temp = ((num - (hundreds * 100)) / 10);
                    tens = (((int)Math.Round(temp)) * 10);
                    s = (num - (hundreds * 100));
                    switch (tens)
                    {
                        case 20: Console.Write(" twenty "); break;
                        case 30: Console.Write(" thirty "); break;
                        case 40: Console.Write(" fourty "); break;
                        case 50: Console.Write(" fifty "); break;
                        case 60: Console.Write(" sixty "); break;
                        case 70: Console.Write(" seventy "); break;
                        case 80: Console.Write(" eighty "); break;
                        case 90: Console.Write(" ninety "); break;
                    }
                    switch (s)
                    {
                        case 10: Console.Write(" ten "); break;
                        case 11: Console.Write(" eleven "); break;
                        case 12: Console.Write(" twelve "); break;
                        case 13: Console.Write(" thirteen "); break;
                        case 14: Console.Write(" fourteen "); break;
                        case 15: Console.Write(" fifteen "); break;
                        case 16: Console.Write(" sixteen "); break;
                        case 17: Console.Write(" seventeen "); break;
                        case 18: Console.Write(" eighteen "); break;
                        case 19: Console.Write(" nineteen "); break;
                    }
                    int singles;
                    if ((num != 0) && (s < 11) || (num != 0) && (s > 19))
                    {
                        singles = ((num - (hundreds * 100)) - tens);
                        switch (singles)
                        {
                            case 1: Console.Write(" one "); break;
                            case 2: Console.Write(" two "); break;
                            case 3: Console.Write(" three "); break;
                            case 4: Console.Write(" four "); break;
                            case 5: Console.Write(" five "); break;
                            case 6: Console.Write(" six "); break;
                            case 7: Console.Write(" seven "); break;
                            case 8: Console.Write(" eight "); break;
                            case 9: Console.Write(" nine "); break;
                        }
                    }
                }
            }
            else
            {
                double tempOne;
                int tensOne;
                int sOne;
                int hundredsOne;
                hundredsOne = num / 100;
                if (num / 10 != 0)
                {
                    tempOne = ((num - (hundredsOne * 100)) / 10);
                    tensOne = (((int)Math.Round(tempOne)) * 10);
                    sOne = (num - (hundredsOne * 100));
                    switch (tensOne)
                    {
                        case 20: Console.Write(" twenty "); break;
                        case 30: Console.Write(" thirty "); break;
                        case 40: Console.Write(" fourty "); break;
                        case 50: Console.Write(" fifty "); break;
                        case 60: Console.Write(" sixty "); break;
                        case 70: Console.Write(" seventy "); break;
                        case 80: Console.Write(" eighty "); break;
                        case 90: Console.Write(" ninety "); break;
                    }
                    switch (sOne)
                    {
                        case 10: Console.Write(" ten "); break;
                        case 11: Console.Write(" eleven "); break;
                        case 12: Console.Write(" twelve "); break;
                        case 13: Console.Write(" thirteen "); break;
                        case 14: Console.Write(" fourteen "); break;
                        case 15: Console.Write(" fifteen "); break;
                        case 16: Console.Write(" sixteen "); break;
                        case 17: Console.Write(" seventeen "); break;
                        case 18: Console.Write(" eighteen "); break;
                        case 19: Console.Write(" nineteen "); break;
                    }
                    int singles;
                    if ((num != 0) && (sOne < 11) || (num != 0) && (sOne > 19))
                    {
                        singles = ((num - (hundredsOne * 100)) - tensOne);
                        switch (singles)
                        {
                            case 1: Console.Write(" one "); break;
                            case 2: Console.Write(" two "); break;
                            case 3: Console.Write(" three "); break;
                            case 4: Console.Write(" four "); break;
                            case 5: Console.Write(" five "); break;
                            case 6: Console.Write(" six "); break;
                            case 7: Console.Write(" seven "); break;
                            case 8: Console.Write(" eight "); break;
                            case 9: Console.Write(" nine "); break;
                        }
                    }
                }
            }
        }
    }
}
