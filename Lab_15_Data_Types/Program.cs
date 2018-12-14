using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //32-bit
            int num01;
            //16-bit
            short num02;
            //64-bit
            long num03;
            uint num04;

            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);

            float num05 = 1.2345F;
            double num06 = 1.2345;
            decimal num07 = 1.2345M;

            string string01 = "abc";
            // string is same as an array of characters
            //ASCII 
            //unicode utf-8 : similar to ASCII
            //unicode utf-16 : used in C# : represent basic english and 
            // characters from around the world e.g. chinese symbols
            char char01 = 'f';
            char char02 = (char)102;
            Console.WriteLine(char01);
            Console.WriteLine(char02);
            

        }
    }
}
