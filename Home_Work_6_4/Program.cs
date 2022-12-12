using System.ComponentModel;

namespace Home_Work_6_4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(Calculator.Add(2, 0) + "\n");

            Console.WriteLine(Calculator.Sub(4, 2) + "\n");

            if (Calculator.Div(2, 0) != 0)
            {
                Console.WriteLine(Calculator.Div(2, 0) + "\n");
            }
            else
            {
                Console.WriteLine("На 0 дiлити не можна!\n");
            }
            Console.WriteLine(Calculator.Mul(0, 2));

            Console.ReadKey();
        }
    }
}