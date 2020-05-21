using System;


namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        [Fact]
        public void Test1() //Get returns 3 for fizz?
        { 
            //Arrange

            //Act


            //Assert
            var fizzBuzz = new MyNumber();
            var resultt = FizzBuzz.Get(3);
            Assert.Equals("3", result);
        }
        //public void Number_Divisible_By_Five()
        //{
        //    var fizzBuzz = new FizzBuzz();
        //    var result = fizzBuzz.Get(1);
        //    Assert.Equal("1", result);
        //}
        
    }
}
