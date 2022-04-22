using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Board;

namespace Console_Chess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Position position = new Position(2, 4);

            Console.WriteLine("Position: " + position);

        }
    }
}
