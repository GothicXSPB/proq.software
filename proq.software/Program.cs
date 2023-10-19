

using proq.software;

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 };

FizzBuzz fizzBuzz = new FizzBuzz();
FizzBuzzMuzzGuzz fizzBuzzMuzzGuzz = new FizzBuzzMuzzGuzz();
GoodBoyMuzzGuzz goodBoyMuzzGuzz = new GoodBoyMuzzGuzz();

var res = fizzBuzz.ConvertToFizzBuzz(numbers);
var res1 = fizzBuzzMuzzGuzz.ConvertToFizzBuzzMuzzGuzz(numbers1);
var res2 = goodBoyMuzzGuzz.ConvertToGoodBoyMuzzGuzz(numbers1);

foreach (var item in res)
{
    Console.Write(item + ", ");
}
Console.WriteLine();
foreach (var item in res1)
{
    Console.Write(item + ", ");
}
Console.WriteLine();
foreach (var item in res2)
{
    Console.Write(item + ", ");
}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();