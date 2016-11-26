using System;
using System.Collections.Generic;

namespace ArithmeticalExpressions
{
    class StartUP
    {
        private static int j;

        static byte Precedence(string str)
        {
            byte result = 0;

            if (str == "*" || str == "/")
            {
                result = 3;
            }
            else if (str == "-" || str == "+")
            {
                result = 2;
            }
            else
            {
                result = 10;
            }

            return result;
        }

        static List<string> PushInList(string values)
        {
            string next = String.Empty;
            List<string> list = new List<string>();
            int i = 0;
            bool isFunction = false;
            while (i < values.Length)
            {
                if ((values[i] >= 0x30 && values[i] <= 0x39) || values[i] == 0x2e)
                {
                    while (i < values.Length && ((values[i] >= 0x30 && values[i] <= 0x39) || values[i] == 0x2e))
                    {
                        next += values[i++];
                    }
                    i--;
                }

                if ((values[i] >= 0x61 && values[i] <= 0x7a) || (values[i] >= 0x41 && values[i] <= 0x5a))
                {
                    while (i < values.Length && ((values[i] >= 0x61 && values[i] <= 0x7a) || (values[i] >= 0x41 && values[i] <= 0x5a)))
                    {
                        next += values[i++];
                    }
                    i--;
                    isFunction = true;
                }

                if (values[i] == 0x2d)  // -
                {
                    if (isFunction)
                    {
                        next += values[i++];
                        while (i < values.Length && ((values[i] >= 0x30 && values[i] <= 0x39) || values[i] == 0x2e))
                        {
                            next += values[i++];
                        }
                        i--;
                    }
                    else
                    {
                        next += values[i];
                    }
                }

                if (values[i] == 0x29) // )
                {
                    isFunction = false;
                }

                if ((values[i] >= 0x28 && values[i] <= 0x2b) || values[i] == 0x2c || values[i] == 0x2f)
                {
                    next += values[i];
                }

                if (!String.IsNullOrEmpty(next))
                {
                    list.Add(next);
                }
                i++;
                next = String.Empty;
            }

            return list;
        }

        static List<string> ShuntingYard(List<string> shunt)
        {
            List<string> queue = new List<string>();
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < shunt.Count; i++)
            {
                if (shunt[i].Length > 1)
                {
                    if ((((char)shunt[i][0] >= 0x30) && ((char)shunt[i][0] <= 0x39)) || ((char)shunt[i][0] == 0x2d)) // [0-9] or -
                    {
                        queue.Add(shunt[i]);
                    }
                    else if ((((char)shunt[i][0] >= 0x41) && ((char)shunt[i][0] >= 0x5A)) || (((char)shunt[i][0] >= 0x61) && ((char)shunt[i][0] >= 0x7A))) // [a-z] && [A-z]
                    {
                        stack.Push(shunt[i]);
                    }
                }
                else
                {
                    if (((char)shunt[i][0] >= 0x30) && ((char)shunt[i][0] <= 0x39)) // [0-9]
                    {
                        queue.Add(shunt[i]);
                    }
                    else if ((char)shunt[i][0] == 0x2c)  // ,
                    {
                        bool isComma;
                        do
                        {
                            isComma = false;
                            string tmp = stack.Pop();
                            if (tmp == "(")
                            {
                                isComma = true;
                                stack.Push(tmp);
                            }
                            else
                            {
                                queue.Add(tmp);
                            }

                        } while (!isComma);
                    }
                    else if ((char)shunt[i][0] == 0x2a || (char)shunt[i][0] == 0x2b || (char)shunt[i][0] == 0x2d || (char)shunt[i][0] == 0x2f)  //operators
                    {
                        bool flag;
                        do
                        {
                            flag = true;
                            if (stack.Count > 0)
                            {
                                string tmp = stack.Pop();

                                if (tmp == "*" || tmp == "/" || tmp == "+" || tmp == "-" || (tmp[0] >= 0x41 && tmp[0] <= 0x5a) || (tmp[0] >= 0x61 && tmp[0] <= 0x7a))
                                {
                                    if (Precedence(shunt[i]) <= Precedence(tmp))
                                    {
                                        queue.Add(tmp);
                                    }
                                    else
                                    {
                                        stack.Push(tmp);
                                        stack.Push(shunt[i]);
                                        flag = false;
                                    }

                                }
                                else
                                {
                                    stack.Push(tmp);
                                    stack.Push(shunt[i]);
                                    flag = false;
                                }
                            }
                            else
                            {
                                stack.Push(shunt[i]);
                                flag = false;
                            }
                        } while (flag);
                    }
                    else if ((char)shunt[i][0] == 0x28) // (
                    {
                        stack.Push(shunt[i]);
                    }
                    else if ((char)shunt[i][0] == 0x29) // )
                    {
                        do
                        {
                            string tmp = stack.Pop();
                            if (tmp != "(")
                            {
                                queue.Add(tmp);
                            }
                            else
                            {
                                break;
                            }
                        } while (true);
                    }
                }
            }
            while (stack.Count > 0)
            {
                queue.Add(stack.Pop());
            }

            return queue;
        }

        static int KnownFunction(string function)
        {
            string f = function;
            int result = -1;

            if (f == "log10" || f == "ln" || f == "sqrt" || f == "sin" || f == "cos" || f == "tan" || f == "cotan" || f == "abs")
            {
                result = 1;
            }
            else if (f == "log" || f == "pow" || f == "max" || f == "min" || f == "/" || f == "*" || f == "+" || f == "-")
            {
                result = 2;
            }

            return result;
        }

        static double DoFunction(string fn, Stack<string> stackHere)
        {
            double result = 0;
            double first, second;
            switch (fn)
            {
                case "ln":
                    result = 1.0 / Math.Log(Math.E, double.Parse(stackHere.Pop()));
                    break;
                case "log":
                    first = double.Parse(stackHere.Pop());
                    second = double.Parse(stackHere.Pop());
                    result = Math.Pow(second, first);
                    break;
                case "log10":
                    result = Math.Log(10, double.Parse(stackHere.Pop()));
                    break;
                case "sqrt":
                    result = Math.Sqrt(double.Parse(stackHere.Pop()));
                    break;
                case "sin":
                    result = Math.Sin(double.Parse(stackHere.Pop()));
                    break;
                case "cos":
                    result = Math.Cos(double.Parse(stackHere.Pop()));
                    break;
                case "tan":
                    result = Math.Tan(double.Parse(stackHere.Pop()));
                    break;
                case "cotan":
                    result = 1 / Math.Tan(double.Parse(stackHere.Pop()));
                    break;
                case "abs":
                    result = Math.Abs(double.Parse(stackHere.Pop()));
                    break;
                case "pow":
                    first = double.Parse(stackHere.Pop());
                    second = double.Parse(stackHere.Pop());
                    result = Math.Pow(second, first);
                    break;
                case "max":
                    result = Math.Max(double.Parse(stackHere.Pop()), double.Parse(stackHere.Pop()));
                    break;
                case "min":
                    result = Math.Min(double.Parse(stackHere.Pop()), double.Parse(stackHere.Pop()));
                    break;
                case "*":
                    result = double.Parse(stackHere.Pop()) * double.Parse(stackHere.Pop());
                    break;
                case "/":
                    first = double.Parse(stackHere.Pop());
                    second = double.Parse(stackHere.Pop());
                    result = second / first;
                    break;
                case "-":
                    first = double.Parse(stackHere.Pop());
                    second = double.Parse(stackHere.Pop());
                    result = second - first;
                    break;
                case "+":
                    result = double.Parse(stackHere.Pop()) + double.Parse(stackHere.Pop());
                    break;


                default:
                    break;
            }


            return result;
        }

        static double PostfixAlgorithm(List<string> list)
        {
            List<string> queue = new List<string>();
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length > 1)
                {
                    if ((((char)list[i][0] >= 0x30) && ((char)list[i][0] <= 0x39)) || ((char)list[i][0] == 0x2d)) // [0-9] or -
                    {
                        stack.Push(list[i]);
                    }
                    else if ((((char)list[i][0] >= 0x41) && ((char)list[i][0] >= 0x5A)) || (((char)list[i][0] >= 0x61) && ((char)list[i][0] >= 0x7A))) // [a-z] && [A-z]
                    {
                        string fn = list[i];
                        //int argumentsTaken = KnownFunction(fn);
                        double result = DoFunction(fn, stack);
                        stack.Push(result.ToString());
                    }
                }
                else
                {
                    if (((char)list[i][0] >= 0x30) && ((char)list[i][0] <= 0x39)) // [0-9]
                    {
                        stack.Push(list[i]);
                    }
                    else // operators
                    {
                        string fn = list[i];
                        //int argumentsTaken = KnownFunction(fn);
                        double result = DoFunction(fn, stack);
                        stack.Push(result.ToString());
                    }
                }
            }
            return double.Parse(stack.Pop());
        }

        static double Calculate(string values)
        {

            List<string> list = new List<string>();

            list = PushInList(values);
            list = ShuntingYard(list);

            double result = PostfixAlgorithm(list);

            return result;
        }

        static void Main()
        {
            string values = Console.ReadLine();

            Console.WriteLine("{0:F}", Calculate(values));
        }
    }
}
