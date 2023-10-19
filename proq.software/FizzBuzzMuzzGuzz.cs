
namespace proq.software
{
    public class FizzBuzzMuzzGuzz
    {
        public List<string> ConvertToFizzBuzzMuzzGuzz(int[] numbers)
        {

            List<string> result = new List<string>();

            foreach (int number in numbers)
            {
                string temp = string.Empty;

                if (number % 3 == 0)
                {
                    temp = "fizz";
                }
                if (number % 4 == 0)
                {
                    if (temp != string.Empty)
                    {
                        temp += "-muzz";
                    }
                    else 
                    { 
                    temp += "muzz";                    
                    }
                }
                if (number % 5 == 0)
                {
                    if (temp != string.Empty)
                    {
                        temp += "-buzz";
                    }
                    else
                    {
                    temp += "buzz";
                    }
                }
                if (number % 7 == 0)
                {
                    if (temp != string.Empty)
                    {
                        temp += "-guzz";
                    }
                    else
                    {
                    temp += "guzz";
                    }
                }
                else
                {
                    if (temp == string.Empty)
                    {
                        result.Add(number.ToString());
                        continue;
                    }    
                }

                result.Add(temp);
            }
            return result;
        }
    }
}
