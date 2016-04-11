using System;

class Program
{
    static void Main()
    {
        char a;
        for (int i = 33; i < 127 ; i++) {
            a = (char)i;
            Console.Write(a);
        }
    }
}