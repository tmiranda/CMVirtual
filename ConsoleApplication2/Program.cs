using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteInstructionsToCustomer();

            var triggers = GetTriggersFromCustomer();

            ICustomerApi api = new customerapi();

            //var answer = api.get_list_of_numbers(int.MaxValue);
            var answer = api.GetNumbers(100);
            if (!answer.Any())
            {
                Console.WriteLine("There was a problem with the upper bound.");
            }
            else
            {
                foreach (var x in answer)
                { Console.WriteLine(x); }
            }
            WriteEndInstructionsToCustomer();
            Console.ReadKey();
        }

        private static Dictionary<int, string> GetTriggersFromCustomer()
        {
            var triggers = new Dictionary<int, string>();
            string triggerValue;
            while ((triggerValue = Console.ReadLine()) != "go")
            {
                var triggerKey = int.Parse(triggerValue.Split(',')[0]);
                if (!triggers.ContainsKey(triggerKey))
                {
                    triggers.Add(triggerKey, triggerValue.Split(',')[1].Trim());
                }
            }

            return triggers;
        }

        private static void WriteEndInstructionsToCustomer()
        {
            Console.WriteLine("Press any key to continue");
        }

        private static void WriteInstructionsToCustomer()
        {
            Console.WriteLine("Enter each trigger value and its associated output value separated by a comma and press Enter (ex. 3,fizz).");
            Console.WriteLine("When finished, type 'go' and press Enter.");
        }
    }
}
