using proq.software;

namespace test.proq.software
{
    public class GoodBoyMuzzGuzzTests
    {
        [Test]
        public void TestConvertToGoodBoyMuzzGuzzTests()
        {
            GoodBoyMuzzGuzz GoodBoyMuzzGuzzConverter = new GoodBoyMuzzGuzz();

            int[] inputNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };
            List<string> result = GoodBoyMuzzGuzzConverter.ConvertToGoodBoyMuzzGuzz(inputNumbers);

            List<string> expected = new List<string>
            {
                "1", "2", "dog", "muzz", "cat", "dog", "guzz", "muzz", "dog", "cat", "11", "dog-muzz", "13", "guzz", "good-boy", "good-boy-muzz", "good-boy-guzz", "good-boy-muzz-guzz"
            };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
