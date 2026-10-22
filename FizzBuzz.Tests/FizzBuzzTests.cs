using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests;

/// <summary>
/// FizzBuzz TDD Kata — Week 8
///
/// Rules:
/// 1. Write a failing test FIRST. Run it. Confirm it fails.
/// 2. Write the minimum code to make it pass. Run all tests.
/// 3. Refactor if needed. Run all tests again.
/// 4. Repeat for the next iteration.
///
/// Do NOT write FizzBuzzCalculator code until you have a failing test.
/// </summary>
[TestClass]
public class FizzBuzzTests
{
    [TestMethod]
    public void Calculate_NumberOfOne_ReturnsNumberAsString()
    {
        string result = FizzBuzzCalculator.Calculate(1);

        Assert.AreEqual(result, "1");
    }

    [TestMethod]
    public void Calculate_NumberOfThree_ReturnsFizz()
    {
        string result = FizzBuzzCalculator.Calculate(3);

        Assert.AreEqual(result, "Fizz");
    }
    [TestMethod]
    public void Calculate_NumberOfFive_ReturnsBuzz()
    {
        string result = FizzBuzzCalculator.Calculate(5);

        Assert.AreEqual(result, "Buzz");
    }

    [TestMethod]
    public void Calculate_NumberOfFifteen_ReturnsFizzBuzz()
    {
        string result = FizzBuzzCalculator.Calculate(15);

        Assert.AreEqual(result, "FizzBuzz");
    }

    [TestMethod]
    public void Calculate_NumberOfThirty_ReturnsFizzBuzz()
    {
        string result = FizzBuzzCalculator.Calculate(30);

        Assert.AreEqual(result, "FizzBuzz");
    }
    // Write your tests below — one iteration at a time.
    // Iteration 1: test that Calculate(1) returns "1"
    // Iteration 2: test that Calculate(3) returns "Fizz"
    // Iteration 3: test that Calculate(5) returns "Buzz"
    // Iteration 4: test that Calculate(15) returns "FizzBuzz"
    // Iteration 5: pick at least one edge case and test it
}
