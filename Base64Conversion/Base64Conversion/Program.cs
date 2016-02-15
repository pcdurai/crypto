using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLocalLibrary;


namespace Base64Conversion
{
    class Program
    {
        static void Main(string[] args)
        {

            // Base 64 testing 
            Console.WriteLine("Start: Base 64 testing -------------------------------");
            var inputString = "JkAT4OA3u9uJIe52ek7BobwBO:DzrxdQpIrSK7uBqsU1wHqXWBszymAq3LrFoqmtSjDI2MFzyj28";
            var outputString1 = Base64Util.Base64Encode(inputString);
            Console.WriteLine("Encoded string: " + outputString1);
            Console.WriteLine("End: Base 64 testing -------------------------------");


            // Time stamp testing 
            Console.WriteLine("Start: Time stamp testing -------------------------------");
            Console.WriteLine();
            Console.WriteLine("Time stamp : " + DateTimeUtil.GenerateTimeStamp());
            Console.WriteLine("End: Time stamp testing-------------------------------");
        }

       


    }
}
