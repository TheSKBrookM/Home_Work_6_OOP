using System.Diagnostics.CodeAnalysis;

namespace Home_Work_6_2
{
    internal class Program
    {
        static void Main()
        {
            Book.Notes note = new Book.Notes();

            note.Note = "What is this?";

            note.Show();

            Console.WriteLine(new string('-', 20));

            note.Note = "Ooh, I got it!";

            note.Show();

            Console.ReadKey();
        }
    }
}