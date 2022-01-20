using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ExpertDocument : ProDocumentProgram
    {

        public void ExpertDocumentMenu()
        {
            ConsoleKey key;

            Console.Clear();
            Console.WriteLine("1. Document Opened\n2. Document Edited\n3. Document Saved int pdf format");

            key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.D1) OpenDocument();
            else if (key == ConsoleKey.D2) EditDocument();
            else if (key == ConsoleKey.D3) SaveDocument();
            else
            {
                Console.WriteLine("\nWrong choice");
                Thread.Sleep(1000);
                ExpertDocumentMenu();
            }
        }
    }
}
