using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerApi api = new customerapi();

            var answer = api.get_list_of_numbers(int.MaxValue);
            if(!answer.Any())
            {
                Console.WriteLine("There was a problem with the upper bound.");
            }else
            {
                foreach(var x in answer)
                { Console.WriteLine(x); }
            }
            Console.ReadKey();
        }

    }
}
