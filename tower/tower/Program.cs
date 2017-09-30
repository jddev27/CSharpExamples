using System;
using System.ComponentModel.DataAnnotations;

namespace tower
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var nFloors = 3;
            var n = 0;

            var floorArray = new string[nFloors];
            while (nFloors !=0)
            {
                var firstFloor = (nFloors * 2) - 1;
                var floorString = new string('*', firstFloor);
                floorArray[n] = floorString;
                n++;
                nFloors--;
            }
            foreach (var i in floorArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
