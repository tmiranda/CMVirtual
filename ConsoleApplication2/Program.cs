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
            int upperBound = GetUpperBoundFromCustomer();

            WriteInstructionsToCustomer();

            var triggers = GetTriggersFromCustomer();

            ICustomerApi api = new CustomerApi();

            foreach (var x in api.GetNumbers(upperBound, triggers))
            {
                Console.WriteLine(x);
            }

            WriteEndInstructionsToCustomer();

            Console.ReadKey();
        }

        private static int GetUpperBoundFromCustomer()
        {
            var message = "Enter a number to be used as the upper bound for the operation and press enter:";
            Console.WriteLine(message);

            int upperBoundFromCustomer;
            while (!int.TryParse(Console.ReadLine(), out upperBoundFromCustomer))
            {
                Console.WriteLine(message);
            }

            return upperBoundFromCustomer;
        }

        private static Dictionary<int, string> GetTriggersFromCustomer()
        {
            var triggers = new Dictionary<int, string>();
            string triggerValue;
            while ((triggerValue = Console.ReadLine()) != "go")
            {
                var keyvalue = triggerValue.Split(',');
                if(keyvalue.Count() == 2)
                {
                    int triggerKey;
                    if(int.TryParse(triggerValue.Split(',')[0], out triggerKey))
                    {
                        if (!triggers.ContainsKey(triggerKey))
                        {
                            triggers.Add(triggerKey, triggerValue.Split(',')[1].Trim());
                        }
                    }
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
