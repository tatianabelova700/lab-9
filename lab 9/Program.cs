using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                long x;
                float y;
                char K;
                double answer = 0;

                Console.Write("x = ");
                x = Convert.ToInt64(Console.ReadLine());
                Console.Write("y = ");
                y = Convert.ToSingle(Console.ReadLine());
                Console.Write("operation (+, -, /, *, %) = ");
                K = Convert.ToChar(Console.ReadLine());

                switch (K)
                {
                    case '+':
                        answer = x + y;
                        break;
                    case '-':
                        answer = x - y;
                        break;
                    case '*':
                        answer = x * y;
                        break;
                    case '/':
                        answer = x / y;
                        break;
                    case '%':
                        answer = x % y;
                        break;
                }

                Console.WriteLine("Answer is {0}", answer.ToString());
                Console.ReadLine();
            }
        }
    }
}
