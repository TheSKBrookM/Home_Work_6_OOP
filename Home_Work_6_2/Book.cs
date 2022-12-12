using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_6_2
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Пошук рядка : " + str);
        }
        public class Notes
        {
            private string note = "";

            public string Note
            {
                get
                {
                    return note;
                }
                set
                {
                    if (note != "")
                    {
                        note += " ";
                    }
                    note += value;
                }
            }

            public void Show()
            {
                Console.WriteLine(note);
            }
        }
    }
}
