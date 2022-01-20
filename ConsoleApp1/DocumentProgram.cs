using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DocumentProgram
    {

        public void OpenDocument()
        {
            Console.Clear();
            Console.WriteLine("1. Document Opened\n" +
                              "2. Can Edit in Pro and Expert versions\n" +
                              "3. Can Save in Pro and Expert versions");
        }

        

        public virtual void EditDocument()
        {
            Console.Clear();
            Console.WriteLine("1. Document Opened\n" +
                                          "2. Can Edit in Pro and Expert versions\n" +
                                          "3. Can Save in Pro and Expert versions");
        }



        public virtual void SaveDocument()
        {
            Console.Clear();
            Console.WriteLine("1. Document Opened\n" +
                              "2. Can Edit in Pro and Expert versions\n" +
                              "3. Can Save in Pro and Expert versions");
        }
    }
}
