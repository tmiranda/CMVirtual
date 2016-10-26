using NUnit.Framework;

namespace ClassLibrary1.test
{
    [TestFixture]
    public class test_customerapi
    {
        [TestCase]
        public void is_value_fifteen_fizz()
        {
            int input_to_test = 15;
            var api = new customerapi();
            Assert.AreEqual(api.get_list_of_numbers(input_to_test)[0], "fizz");
        }
    }
}
