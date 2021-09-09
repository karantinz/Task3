using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictures;
            int totalPictures = 52;
            int filledRows = 0;

            for (pictures = 0; pictures < totalPictures; pictures += 3)
            {
                Console.WriteLine("Картинок - " + pictures);
                Console.WriteLine("Всего рядов заполнено - " + filledRows++);
                Console.ReadKey();
            }
        }
    }
}
