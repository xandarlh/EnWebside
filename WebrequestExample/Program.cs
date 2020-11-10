using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebrequestExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Manager manager = new Manager();

            Console.WriteLine(manager.MakeWebRequest("http://google.com"));
            Console.WriteLine(manager.MakeFileRequest(@"C:\Users\alex303a\Desktop\Skole\test.txt"));

            Console.ReadLine();


        }
    }
}
