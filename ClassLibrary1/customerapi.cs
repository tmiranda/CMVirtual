using System.Collections.Generic;

namespace ClassLibrary1
{
    public class customerapi : ICustomerApi
    {
        public List<string> get_list_of_numbers(int upperBound)
        {
            var returnlist = new List<string>();
            if (upperBound > 1)
            {
                for (var x = 1; x <= upperBound; x++)
                {
                    var write_num = true;
                    if (x % 3 == 0)
                    {
                        returnlist.Add("zip");
                        write_num = false;
                    }
                    if (x % 5 == 0)
                    {
                        returnlist.Add("fizz");
                        write_num = false;
                    }
                    if (write_num)
                    {
                        returnlist.Add(x.ToString());
                        write_num = true;
                    }
                }
                return returnlist;
            }
            else
            {
                return returnlist;
            }
        }
    }
}
