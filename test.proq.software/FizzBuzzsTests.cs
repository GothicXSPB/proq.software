using proq.software;

namespace test.proq.software
{
    public class FizzBuzzsTests
    {
        [Test]
        public void TestConvertToFizzBuzz()
        {
            FizzBuzz fizzBuzzConverter = new FizzBuzz();

            int[] inputNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            List<string> result = fizzBuzzConverter.ConvertToFizzBuzz(inputNumbers);

            List<string> expected = new List<string>
            {
                "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizz-buzz", "fizz-buzz", "fizz-buzz", "fizz-buzz"
            };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}