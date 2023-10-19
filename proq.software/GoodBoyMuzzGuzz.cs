namespace proq.software
{
    public class GoodBoyMuzzGuzz
    {

        public List<string> ConvertToGoodBoyMuzzGuzz(int[] numbers)
        {

            List<string> result = new List<string>();


            foreach (int number in numbers)
            {
                string temp = string.Empty;

                if (number % 15 == 0)
                {
                    temp = "good-boy";
                    if (number % 4 == 0)
                    {
                        temp += "-muzz";

                    }
                    if (number % 7 == 0)
                    {
                        temp += "-guzz";

                    }
                    result.Add(temp);
                    continue;
                }
                if (number % 3 == 0)
                {
                    temp = "dog";
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
                        temp += "-cat";
                    }
                    else
                    {
                    temp += "cat";
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


