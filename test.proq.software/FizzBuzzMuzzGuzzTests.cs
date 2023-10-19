using proq.software;

namespace test.proq.software
{
    public class FizzBuzzMuzzGuzzTests
    {
        [Test]
        public void TestConvertToFizzBuzzMuzzGuzz()
        {
            FizzBuzzMuzzGuzz fizzBuzzMuzzGuzzConverter = new FizzBuzzMuzzGuzz();

            int[] inputNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            List<string> result = fizzBuzzMuzzGuzzConverter.ConvertToFizzBuzzMuzzGuzz(inputNumbers);

            List<string> expected = new List<string>
            {
                "1", "2", "fizz", "muzz", "buzz", "fizz", "guzz", "muzz", "fizz", "buzz", "11", "fizz-muzz", "13", "guzz", "fizz-buzz", "fizz-muzz-buzz", "fizz-buzz-guzz", "fizz-muzz-buzz-guzz"
            };

            CollectionAssert.AreEqual(expected, result);
        }
    }

}
