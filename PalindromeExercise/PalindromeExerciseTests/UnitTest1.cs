using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("hannah", true)]
        [InlineData("painting", false)]
        [InlineData("racecar", true)]
        public void Test1(string word, bool expected)
        {
            //Arrange
            WordSmith wordSmith = new WordSmith();

            //Act
            var actual = wordSmith.IsPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
