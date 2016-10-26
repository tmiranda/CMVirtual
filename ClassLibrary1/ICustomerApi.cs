using System.Collections.Generic;

namespace ClassLibrary1
{
    public interface ICustomerApi
    {
        IEnumerable<string> GetNumbers(int upperBound, Dictionary<int,string> triggers);

    }
}
