using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {   //Three ways to create an array:

        // One:
        int[] numarray = new int[5];
        numarray[0] = 5;
        numarray[1] = 2;
        numarray[2] = 10;
        numarray[3] = 200;
        numarray[4] = 5000;

        //Two:
        int[] numarray1 = new int[] { 5, 2, 10, 200, 5000 };

        //Three:
        int[] numarray2 = { 5, 2, 10, 200, 5000 };

        Console.WriteLine(numarray2[3]);
        Console.WriteLine("Appending...");

        numarray2[4] = 250;
        Console.WriteLine(numarray2[4]);
        Console.ReadLine();

        //Lists:
        //Ways to create lists:

        //ONE:
        List<int> intlist = new List<int>();

        intlist.Add(4);
        intlist.Add(10);

        List<string> stringlist = new List<string>();
        stringlist.Add("Hello");
        stringlist.Add("How are you?");

        //TWO:
        List<int> intlist1 = new List<int> { 4, 10 };

        List<string> stringlist1 = new List<string> { "hello", "How are you?" };

        //THREE:
        List<int> intlist2 = [4, 10];
        List<string> stringlist2 = ["Hello", "How are you?"];

        Console.WriteLine(intlist2[0]);
        Console.WriteLine(stringlist2[0]);
        Console.ReadLine();
    }
}