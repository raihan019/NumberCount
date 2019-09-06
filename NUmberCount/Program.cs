using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUmberCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number");
            int value = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(value, 2);

            string[] nums = new String[binary.Length];
            Console.WriteLine("Binary representation of a number is : "+ binary);
            int count = 0;
            int position = 0;
            foreach (char ch in binary)
            {
                if (String.Equals(ch, '1'))
                {
                    nums[position] = position.ToString();
                    count++;
                }
                position++;

            }
            Console.WriteLine("ToTal NUmber Of 1 is : " + count);
            Console.WriteLine("Positions Are :");

            foreach (var pos in nums)
            {
                if (pos != null)
                {
                    Console.WriteLine(pos.ToString());
                }


            }

            Console.ReadKey();
        }
    }
}
