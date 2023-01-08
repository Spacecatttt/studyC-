using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Program
{
    class Program {
       // деякий текст
       // 

        static void Main(string[] args)
        {
            //String regex = (@"0|10*10*10*");
            //String regex = (@"(0|100((1|00)0)*011)+");
            /* String regex =  @"(0|111|100((1|00)0)*011|(101|100((1|00)0)*(1|00)1)(1((1|00)0)*(1|00)1)*(01|1((1|00)0)*011)|(110|100((1|00)0)*010|(101|100((1|00)0)*(1|00)1)(1((1|00)0)*(1|00)1)*(00|1((1|00)0)*010))(1|0(1((1|00)0)*(1|00)1)*(00|1((1|00)0)*010))*0(1((1|00)0)*(1|00)1)*(01|1((1|00)0)*011))*";
             for (int i = 0; i < 100; i++) {
                 //Console.Write($"For {i}({Convert.ToString(i, 2)}): ");
                 if(Regex.Match(Convert.ToString(i, 2), regex).Success != (i % 7 == 0))
                 {

                     Console.WriteLine($"for {i}({Convert.ToString(i, 2)}): ");

                 }

              }
             Console.Write($"For '': ");
             if (Regex.Match("", regex).Success)
             {
                 Console.WriteLine("True");
             }
             else
             {
                 Console.WriteLine("False");
             }
             Console.WriteLine(); 
            */
            //for (int i = 0; i <  100; i++) {
            //    if (i % 7 == 0)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine($"For {i} = {Convert.ToString(i, 2)}");
            //    }
            //    else
            //    {
            //        Console.ResetColor();
            //        Console.WriteLine($"For {i} = {Convert.ToString(i, 2)}");
            //    }
            //}
             
        }
    }
}
