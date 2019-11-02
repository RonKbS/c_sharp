using System;
using Acme.Collections;
class Example
{
    static void Main()
    {
        Stack s = new Stack();
        s.Push(1);
        s.Push(10);
        s.Push(100);
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());
        // a debuger can be attached here.
        Console.WriteLine("Press enter to close...");
        Console.ReadLine();
    }
}

// csc /r:acme.dll C:\Users\Ron\Desktop\c_sharp\example.cs
