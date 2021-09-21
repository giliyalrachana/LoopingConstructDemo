using System;

namespace LoopingConstructs
{
    // This program demo. how to write Do While Loop
    class DoWhileLoop
    {
        static void Main()
        {
            int sum = 0;
            int i = 1;
            do
            {
                sum = sum + i;
                Console.WriteLine($"Sum is {sum}");
                i++;
            } while (i <= 15);
            Console.ReadLine();
        }
    }
}
