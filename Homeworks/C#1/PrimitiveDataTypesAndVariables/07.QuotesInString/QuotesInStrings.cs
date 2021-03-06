﻿using System;

//Problem 7. Quotes in Strings

//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

class QuotesInStrings
{
    static void Main(string[] args)
    {
        //The "use" of quotations causes difficulties.
        string firstVar = "The \"use\" of quotations causes difficulties.";
        string secondVar = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(firstVar);
        Console.WriteLine(secondVar);
    }
}

