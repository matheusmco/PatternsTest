using System;

namespace CompositeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Number(3);

            var e = a.GetChildren();

            foreach (var item in e)
            {
                foreach(var b in item.Value)
                {
                    Console.Write(b);
                }
                Console.WriteLine();
            }
        }
    }
}
