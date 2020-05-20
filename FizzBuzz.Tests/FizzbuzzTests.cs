using System;


namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        static void Test1()
        {
            var fizzBuzz = new FizzBuzz();
            var result = fizzBuzz.Get(1);
            Assert.Equal("1", result);
        }
    }
}
