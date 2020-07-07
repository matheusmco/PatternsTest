using System;

namespace CompositeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Number(3);
            var b = new Number(2);
            var c = new Number(1);
            b.Add(c);
            a.Add(b);

            a.Display(1);
        }
    }
}
