using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowCount = 0, colCount = 0;
            bool startX = true;

            while (rowCount < 8)
            {
                while (colCount < 8)
                {
                    if(startX)
                        Console.Write('X');
                    else
                        Console.Write('O');
                    startX = !startX;
                    colCount++;
                }
                startX = !startX;
                Console.Write('\n');
                rowCount++;
                colCount = 0;
            }
            Console.ReadLine();
        }
    }
}
