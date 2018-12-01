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

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr) {
        var result = int.MinValue;
        
        for (var j = 1; j <= 4; j++)
        {
            for (var i = 1; i <= 4; i++)
            {
                var sum = arr[j - 1][i - 1] + arr[j - 1][i] + arr[j - 1][i + 1] +
                          arr[j][i] +
                          arr[j + 1][i - 1] + arr[j + 1][i] + arr[j + 1][i + 1];

                result = Math.Max(result, sum);
            }    
        }

        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
