using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0,-10}{1,-10}","Item Name","Item Price");
            var reader = new StreamReader(File.OpenRead("items.csv"));
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                var values = line.Split(',');
                Console.WriteLine("{0,-10}{1,-10}",values[0],values[1]);
            }
        }
    }
}
