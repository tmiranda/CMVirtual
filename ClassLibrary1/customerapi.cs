using System.Collections.Generic;

namespace ClassLibrary1
{
    public class customerapi : ICustomerApi
    {

        public IEnumerable<string> GetNumbers(int upperBound)
        {
            if(upperBound>0)
            {
                string return_value;
                //loop from 1 to the upper bound passed in
                for (var iteration = 1; iteration <= upperBound; iteration++)
                {
                    return_value = string.Empty;
                    if (iteration % 3 == 0)
                    {
                        return_value += "zip ";
                    }
                    if (iteration % 5 == 0)
                    {
                        return_value += "fizz";
                    }
                    if (string.IsNullOrEmpty(return_value))
                    {
                        return_value = iteration.ToString();
                    }
                    yield return return_value;
                }
            }

        }

    }
}
