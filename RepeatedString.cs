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

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n) {
        var numberOfAInRepeatString = s.Count(c => c == 'a');
        if (numberOfAInRepeatString == 0)
            return 0;
        
        var repeatStringLength = s.Length;
        var numberOfFullRepeats = n / repeatStringLength;
        var numberOfAInFullRepeats = numberOfFullRepeats * numberOfAInRepeatString;
        
        var lastRepeatStringLength = (int) (n % repeatStringLength);
        if (lastRepeatStringLength == 0)
            return numberOfAInFullRepeats;
        var lastRepeatString = s.Substring(0, lastRepeatStringLength);
        var numberOfAInLastRepeatString = lastRepeatString.Count(c => c == 'a');

        return numberOfAInFullRepeats + numberOfAInLastRepeatString;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
