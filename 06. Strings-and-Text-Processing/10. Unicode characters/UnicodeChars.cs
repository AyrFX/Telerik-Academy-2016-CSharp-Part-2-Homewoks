﻿using System;

class UnicodeChars
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        string outputString = string.Empty;

        for (int i = 0; i < inputString.Length; i++)
        {
            Console.Write("\\u");
            Console.Write(string.Format("{0:X4}", Convert.ToInt16(inputString[i])));
            //outputString += "\\u" + string.Format("{0:X4}", Convert.ToInt16(inputString[i]));
        }
        //Console.WriteLine(outputString);
        Console.WriteLine();
    }
}