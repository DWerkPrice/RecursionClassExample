﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionClassExample
{
    class Factorial
    {
        public static int factorial(int n) {
            if(n == 1) {
               return 1;
            }
            return n * factorial(n - 1);
        }
    }
}
