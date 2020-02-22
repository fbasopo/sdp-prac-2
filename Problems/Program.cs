using System;

namespace Problems
{
    public class Program
    {
        public static string Prefix(string input)
        {
            int inp = input.Length;
            string[] wrds = input.Split(" ");
            int numWords = wrds.Length;
            int lenword = 0;
            foreach(string i in wrds)
            {
                if(i != "")
                {
                    lenword ++;
                }
            }

            if(input ==""){
                numWords= 0;
            }
        

            string ans =inp + ","+ lenword + ":" + input;
            return ans;

        }
        static void Main(string[] args)
        {
            string name = "hello";
           Prefix(name);
            
        }
    }
}
