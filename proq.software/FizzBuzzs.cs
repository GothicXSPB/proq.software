namespace proq.software
{
    public class FizzBuzz
    {
        public List<string> ConvertToFizzBuzz(int[] numbers)
        {

            List<string> result = new List<string>();

            foreach (int number in numbers)
            {
                if (number % 15 == 0)
                {
                    result.Add("fizz-buzz");
                    continue;
                }
                else if (number % 5 == 0)
                {
                    result.Add("buzz");
                    continue;
                }
                else if (number % 3 == 0)
                {
                    result.Add("fizz");
                    continue;
                }
                else
                {
                    result.Add(number.ToString());
                }
            }
            return result;
        }
    }
}
