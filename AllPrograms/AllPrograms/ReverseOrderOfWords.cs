using System;
using System.Collections.Generic;
using System.Text;

namespace AllPrograms
{
    class ReverseOrderOfWords
    {
        static void Main(string[] args)
        {
            String str = "testing is still pending";
            String[] str1 = str.Split(" ");
            int k = str.Length - 1;
            int temp = k;
            
            for (int i = k; temp > 0; k--)
            {
               // str1 = str1[k]
            }
            Console.WriteLine("Reverse of words {0}",str1); 
        }
    }
}
