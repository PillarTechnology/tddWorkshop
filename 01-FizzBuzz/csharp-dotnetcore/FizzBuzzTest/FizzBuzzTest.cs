using System;
using Xunit;

namespace Katas
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Returns1For1()
        {
            var fizzBuzz = new FizzBuzz();
            var actualReturnValue = fizzBuzz.Process(1);
            var expectedReturnValue = "1";
            Assert.Equal(expectedReturnValue, actualReturnValue);
        }
    }
}
