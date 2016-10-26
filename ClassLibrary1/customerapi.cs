using System.Collections.Generic;

namespace ClassLibrary1
{
    public class CustomerApi : ICustomerApi
    {
        Dictionary<int, string> triggerValues;

        public IEnumerable<string> GetNumbers(int upperBound, Dictionary<int, string> triggers)
        {
            if(upperBound>0)
            {
                triggerValues = triggers;
                for (var iteration = 1; iteration <= upperBound; iteration++)
                {
                    yield return BuildStringForThisIterationValue(iteration);
                }
            }
        }

        private string BuildStringForThisIterationValue(int iteration)
        {
            var returnValue = string.Empty;
            foreach(var trigger in triggerValues)
            {
                if(iteration % trigger.Key == 0)
                {
                    returnValue += trigger.Value;
                }
            }
            if (string.IsNullOrEmpty(returnValue))
            {
                returnValue = iteration.ToString();
            }
            return returnValue;
        }
    }
}
