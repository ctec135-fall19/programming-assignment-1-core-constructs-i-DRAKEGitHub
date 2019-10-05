/*
Author: <Allison Drake>
Date:   <10/05/2019>
CTEC 135: Microsoft Software Development with C#

<CS_Core_Constructs_I>

<Problem description from README.md file. Make sure the comment text is 
reformatted to fit 1-80 column display, with appropriate indentations to 
make it readable>

Example:
Prob 1: Prob 1: Variables and Printing

* region 1: variable declarations

    page 18 in Troelsen shows two different ways to declare int variables. 
    page 71 shows a third way using the "new" keyword.

    In this section declare three different double variables using each of 
    the three type declarations.
...

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1: variable declarations
            double a = 0;
            System.Double b = 0;
            double c = new double();
            #endregion

            #region 2: variable initialization
            // declare CLS compliant numeric type variables
            System.Byte myByte = 127;
            System.Int16 myShort = 32767;
            System.Int32 myInt = 2147483647;
            System.Int64 myLong = 9223372036854775807;
            System.Single myFloat = 3.5f;
            System.Double myDouble = 12.3;
            System.Decimal myDecimal = 7.9m;

            // prints values variables to terminal with format specifiers
            Console.WriteLine("Byte: {0}", myByte);
            Console.WriteLine("Short: {0:n}", myShort);
            Console.WriteLine("Integer: {0:c}", myInt);
            Console.WriteLine("Long: {0:e}", myLong);
            Console.WriteLine("Float: {0:f}", myFloat);
            Console.WriteLine("Double: {0}", myDouble);
            Console.WriteLine("Decimal: {0}", myDecimal);
            #endregion

            #region 3: Max/Min Values
            // prints the minimum and maximum value available for Double 
            Console.WriteLine("The minimum value of Double is: {0}", Double.MinValue);
            Console.WriteLine("The maximum value of Double is: {0}", Double.MaxValue);
            #endregion  
        }
    }
}
