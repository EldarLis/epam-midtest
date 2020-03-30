using System;
using System.IO;
using System.Text;

namespace lab_epam
{
    class Program
    {
        static void Main(string[] args)
        {
            char check;
            Console.WriteLine("Input x and y have to be strictly divided by comma , ");
            Console.WriteLine("Every pair of input have to be on different lines.");
            Console.WriteLine("Spaces are ignored.");
            Console.WriteLine("F/f - for file; K/k - for keyboard. ?:");
            check = char.Parse(Console.ReadLine());
            string[] words;

            StringBuilder res = new StringBuilder();

            if (check == 'f' || check == 'F')
            {
                if (!File.Exists(@"input.txt"))
                {
                    Console.WriteLine("File doesn't exist.\nTerminating process");
                }
                else
                {
                    StreamReader input = new StreamReader("input.txt");

                    string line = input.ReadLine();

                    while (line != null)
                    {

                        words = line.Split(',');
                        res.Append("X: " + words[0].Replace(" ", "") + " \tY: " + words[1].Replace(" ", "") + "\n");
                        line = input.ReadLine();
                    }

                    Console.WriteLine(res.ToString());
                }
            }
            else if (check == 'k' || check == 'K')
            {
                Console.WriteLine("Write lines . Empty line to end");
                string line = Console.ReadLine();
                while (line != "")
                {
                    words = line.Split(',');
                    res.Append("X: " + words[0].Replace(" ", "") + " \tY: " + words[1].Replace(" ", "") + "\n");
                    line = Console.ReadLine();
                }

                Console.WriteLine(res.ToString());
            }
            else
            {
                Console.WriteLine("Wrong input.\nProcess terminated!");
            }

        }
    }
}
