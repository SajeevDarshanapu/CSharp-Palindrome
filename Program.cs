using System;

namespace Sajeev
{
    public class client
    {
        public static void Main(string[]args)
        {
            int num, rem, revnum = 0, temp;
            Console.WriteLine("Enter a number");
            num=Convert.ToInt32(Console.ReadLine());
            temp = num;
            while(num>0)
            {
                rem = num % 10;
                revnum = revnum * 10 + rem;
                num = num / 10;
            }
            if(temp==revnum)
            {
                Console.WriteLine(" It is a paindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
        }
    }
}