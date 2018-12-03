using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q) {
        var result = 0;
        var minNumber = q.Length;
        
        for (var i = q.Length - 1; i >= 0 ; i--)
        {
            var realNumber = q[i];
            var expectedNumber = i + 1;
            
            var bribes = realNumber - expectedNumber;
            
            if (bribes > 2)
            {
                Console.WriteLine("Too chaotic");
                return;
            }

            if (bribes > 0)
            {
                result += bribes;
                continue;
            }

            if (minNumber < realNumber)
            {
                result++;
                continue;
            }
            
            minNumber = realNumber;
        }
                
        Console.WriteLine(result);
    }

    static void Main(string[] args) {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
                ;
            minimumBribes(q);
        }
    }
}
