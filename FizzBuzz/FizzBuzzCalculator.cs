namespace FizzBuzz;

// Do not write anything here until a failing test requires it.
// Start in FizzBuzz.Tests/FizzBuzzTests.cs — write a test first,
// watch it fail, then come back here.
public static class FizzBuzzCalculator
{
    // Your implementation goes here — driven by failing tests.x
    public static string Calculate(int num)
    {
        if(num % 3 == 0 && num % 5 == 0)
        {
            return ("FizzBuzz");
        }
        else if(num % 3 == 0)
        {
            return ("Fizz");
        }
        else if(num % 5 == 0)
        {
            return ("Buzz");
        }
        else
        {
            return num.ToString();
        }
    }
}
