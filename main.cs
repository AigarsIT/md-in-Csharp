using System;

class Program 
{
  static int LKD(int a, int b)
    {
        while (b != 0)
        {
            var t = b;
            b = a % b;
            a = t;
        }
        return a;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Eiklīda algoritms");
        Console.Write("A = ");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.Write("B = ");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Lielākais kopīgais dalītājs skaitļiem {0} un {1} ir vienāds {2}", a, b, LKD(a, b));
        Console.ReadLine();
    }
}