using System;
using System.Collections.Generic;
using System.Text;

namespace Eventualist.Extensions.Tests.Unit.Util
{
    public static class Util
    {
        public static int Fibonacci(int number)
        {
            if (number < 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(number - 1) + Fibonacci(number - 2);
            }
        }
    }
}
