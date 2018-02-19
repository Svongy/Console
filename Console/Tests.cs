using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Tests
    {
        public static void Test1()
        {
            bool esc = false;
            int n = 0;
            String input = null;
            System.Console.WriteLine("Enter Esc to exit");

            while (esc != true)
            {
                int result = 0;
                System.Console.WriteLine("");
                System.Console.WriteLine("Please Enter the number:");
                input = System.Console.ReadLine();
                try
                {
                    n = int.Parse(input);

                    for (int i = 1; i <= n; i++)
                    {
                        result += (2 * i - 1);
                    }
                    System.Console.WriteLine(result);
                }
                catch (FormatException)
                {
                    System.Console.WriteLine("{0} not integer input", input);
                }

                if (input.ToLower().Equals("esc"))
                {
                    esc = true;
                }
            }
        }

        public static void Test2()
        {
            bool esc = false;
            String input = null;
            while (esc != true)
            {
                int result = 0;
                for (int i = 0; i <= 10; i++)
                {
                    result += 2 * i - 1;
                }
                System.Console.WriteLine(result);
                System.Console.WriteLine("Enter Esc to exit");
                input = System.Console.ReadLine();

                if (input.ToLower().Equals("esc"))
                {
                    esc = true;
                }
            }
        }
    }
}
