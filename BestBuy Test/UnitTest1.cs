using System;
using Xunit;
using BestBuy;

namespace BestBuy_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("noon", true)]
        [InlineData("dog", false)]
        public void IsThisAPalindrome(string word, bool expected)
        {
            //Arrange - Create an instance of the class that contains the
            //          method we want to test 
            var palindromeInstance = new Palindrome();

            //Act - Call the method we are testing
            var actual = palindromeInstance.IsThisAPalindrome(word);

            //Assert - See if the actual result is the same as what is expected
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(1, 1)]
        [InlineData(1, 2)]
        public void SumOfNumber(int num1, int num2)
        {
            int answer = num1 + num2;

            var sumOfNumberInstance = new CashRegister();

            var actual = sumOfNumberInstance.SumOfNumber(num1, num2);

            Assert.Equal(answer, actual);
        }

        [Theory]
        [InlineData]
    }
}
