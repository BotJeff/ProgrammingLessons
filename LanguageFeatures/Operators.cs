﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageFeatures
{
    public class Operators
    {
        public void RunAllMethods()
        {
            foreach(var method in this.GetType().GetMethods())
            {
                if(method.Name == nameof(RunAllMethods)) continue;
                try
                {
                    method.Invoke(this, null);
                }
                catch {}
            };
        }

        public void NullablesOperators()
        { //    ?.      ?[     ??
            var nums = Enumerable.Range(0,100).ToArray();
            int? len = nums?.Length; // used to avoid an exception if when calling a property/method on a null object
            int? first = nums?[0]; //same exept with indexers.

            string test = null;
            string rand = test ?? test; // if test not null then assign test
        }


        public void BitWiseOperators()
        {
            // <<= >>= << >> shifts bits to left or right depending on number specified.

            int target = 100;

            int shifted = target >> 1; //shift bits of x to right once and assign to a.
            shifted >>= 2;        //shift a bits to right twice and assign to a.

            // NOTE: bits shifted to far right will be lost. ie. 011 shifted once
            // to the right is 001. In the same way when shifting to the left, the empty
            // space will be filled with a 0.

            // ~ invert bits operator     
            // short is 16 bits
            short c = ~3;
            Convert.ToString(c, 2);

            // & (and) sets bits to 1 if both are 1, 0 if both are zero and 0 if they are different
            c = 3 & 5; //011 & 101 = 001
            Convert.ToString(c, 2);

            // | (or) same as above except it will assign a 1 if they are different
            c = 3 | 5; //011 | 101 = 111
            Convert.ToString(c, 2);
            
            // ^ (exeptional OR) sets 1 if bits are different and 0 if same.
            c = 3 ^ 5; // //011 | 101 = 110
            Convert.ToString(c, 2);
        }

        public void UsefullTipsANDTricks()
        {
            //Detect if two integers have opposite signs
            int zero = 0,
                one = 1,
                negOne = -1,
                two = 2,
                negTwo = -2;

            bool areOppositeSign = ((one ^ negOne) < 0); // true if x and y have opposite signs

            int xord = one ^ negOne;
            int temp = xord >> 1;
            string s = Convert.ToString(two, 2);
        }
        
        public void ChangeSignOnSignedInt()
        {
            // Change a positive number to a negative by
            // inverting the bits, then add one to offset the
            // bit used for negative numbers at the start.
            
            int f = 555; 
            DisplayBin(f);

            f = ~f+1; // to a negative
            DisplayBin(f);

            f = ~f+1; // from a negative
            DisplayBin(f);
        }

        public void SwapValues() // Swap a value in place (no addition space) by using XOR
        {
            int a = 3, b = 6;

            a = a ^ b;
            DisplayBin(a);
            DisplayBin(b);

            b = a ^ b;
            DisplayBin(a);
            DisplayBin(b);

            a = a ^ b;
            DisplayBin(a);
            DisplayBin(b);
        }

        public void DisplayBin(int n)
        {
            string result = Convert.ToString(n, 2);

            Console.WriteLine();
            Console.WriteLine(n);
            Console.WriteLine(result);
            System.Diagnostics.Debug.Print(result);
        }
    }
}
