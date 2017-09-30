using System;

namespace testingword
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "moose";
            var isogram = IsIsogram(str);
            Console.WriteLine(isogram);
        }

        public static bool IsIsogram(string str)
        {
            // Code on you crazy diamond!
            var count = 0;
            for (var i = 0; i < str.Length -1; i++)
            {
                if (str[count] == str[i + 1])
                {
                    return false;
                }
                count++;
            }
            return true;
        }
       
    }
}


