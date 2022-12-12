namespace Home_Work_6_3
{
    internal class Program
    {
        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int r = random.Next(5, 10);

            int[] array = new int[r];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }

            ShowArray(array);

            Console.WriteLine();

            ExtensionArray.SortArray(array);

            ShowArray(array);

            Console.ReadKey();
        }
    }
}