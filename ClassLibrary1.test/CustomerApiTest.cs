using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.test
{
    [TestFixture]
    public class CustomerApiTest
    {
        [Test]
        public void ShouldReturnNumberOfValuesEqualToUpperBound()
        {
            ICustomerApi sut = new CustomerApi();
            var configDictionary = new Dictionary<int, string>();
            int expectedNumberOfValues = sut.GetNumbers(100, configDictionary).Count();
            Assert.That(expectedNumberOfValues, Is.EqualTo(100));
        }
    }
}
