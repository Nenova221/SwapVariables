using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapVariables
{
    public class VariablesSwapper
    {
        public static string SwapVariables(int a, int b)
        {
            if (a > b)
            {
                a = a - b;
                b = a - b;
                a = a + b;
            }
            return ("b, a");
        }

        public static void SwapVariables(int a, int b, string expected)
        {
            throw new NotImplementedException();
        }
    }
}
