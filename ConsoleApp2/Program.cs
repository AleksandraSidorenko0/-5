// See https://aka.ms/new-console-template for more information
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        byte a = 16;
        char b = 'f';
        sbyte c = -28;
        short d = -29565;
        ushort e = 25365;
        int f = -426867;
        uint g = 5278657;
        long h = -54321546834298463;
        ulong i = 6353473963513216843;
        Console.Write("Тип byte ");
        Console.WriteLine(a);
        Console.Write("Тип char ");
        Console.WriteLine(b);
        Console.Write("Тип sbyte ");
        Console.WriteLine(c);
        Console.Write("Тип short ");
        Console.WriteLine(d);
        Console.Write("Тип ushort ");
        Console.WriteLine(e);
        Console.Write("Тип int ");
        Console.WriteLine(f);
        Console.Write("Тип uint ");
        Console.WriteLine(g);
        Console.Write("Тип long ");
        Console.WriteLine(h);
        Console.Write("Тип ulong ");
        Console.WriteLine(i);
        Console.ReadKey();
    }
}