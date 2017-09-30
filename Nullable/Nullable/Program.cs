using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            date = new DateTime(2017,1,1);
            DateTime ? date2 = date?? new DateTime(2014,2,2);
            Console.WriteLine(date.GetValueOrDefault());
            Console.WriteLine(date.HasValue);
            Console.WriteLine(date.Value);
        }
    }
}