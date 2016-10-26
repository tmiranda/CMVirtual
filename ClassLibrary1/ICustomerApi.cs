using System.Collections.Generic;

namespace ClassLibrary1
{
    public interface ICustomerApi
    {
        List<string> get_list_of_numbers(int upperBound);
    }
}
