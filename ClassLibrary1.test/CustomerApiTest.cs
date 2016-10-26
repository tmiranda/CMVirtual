using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

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
            int expectedNumberOfValues = 100;

            int actualNumberOfValues = sut.GetNumbers(100, configDictionary).Count();

            Assert.That(actualNumberOfValues, Is.EqualTo(expectedNumberOfValues));
        }

        [Test]
        public void ShouldReturnNoValuesForBadUpperBound()
        {
            ICustomerApi sut = new CustomerApi();

            var configDictionary = new Dictionary<int, string>();
            int upperBound = 0;
            var actualValues = sut.GetNumbers(upperBound, configDictionary);

            CollectionAssert.IsEmpty(actualValues);
        }

        [Test]
        public void ShouldPrintIterationValueForNonMatchingDivisors()
        {
            ICustomerApi sut = new CustomerApi();
            var configDictionary = new Dictionary<int, string>()
            {
                { 3,"test" }
            };
            string[] outputFromSut = sut.GetNumbers(50, configDictionary).ToArray();
            string expectedNumberOutputValue1 = outputFromSut[1];
            string expectedNumberOutputValue2 = outputFromSut[13];

            Assert.That(expectedNumberOutputValue1, Is.EqualTo("2"));
            Assert.That(expectedNumberOutputValue2, Is.EqualTo("14"));
        }

        [Test]
        public void ShouldPrintTriggerValueForMatchingDivisors()
        {
            ICustomerApi sut = new CustomerApi();
            var configDictionary = new Dictionary<int, string>()
            {
                { 3,"test" }
            };
            string[] outputFromSut = sut.GetNumbers(50, configDictionary).ToArray();
            string expectedTriggerOutputValue1 = outputFromSut[2];
            string expectedTriggerOutputValue2 = outputFromSut[8];

            Assert.That(expectedTriggerOutputValue1, Is.EqualTo("test"));
            Assert.That(expectedTriggerOutputValue2, Is.EqualTo("test"));
        }

        [Test]
        public void ShouldPrintMultipleTriggerValuesForMatchingDivisors()
        {
            ICustomerApi sut = new CustomerApi();
            var configDictionary = new Dictionary<int, string>()
            {
                { 3,"test1" },
                { 5,"test2" }
            };

            string expectedTriggerOutputValue = sut.GetNumbers(50, configDictionary).ToArray()[14];

            Assert.That(expectedTriggerOutputValue, Is.EqualTo("test1test2"));
        }
    }
}
