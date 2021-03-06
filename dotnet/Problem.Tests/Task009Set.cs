﻿namespace LeetCode.Problem.Tests
{
    using LeetCode.Problem.Easy;
    using Xunit;

    public class Task009Set
    {
        #region Public Methods

        [Theory]
        [Trait("Difficulty", "Easy")]
        [Trait("Topic", "Math")]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        [InlineData(0, true)]
        [InlineData(1000021, false)]
        public void CanDetectPalindrome(int input, bool expected)
        {
            // Arrange
            // Act
            var result = new Task009().IsPalindrome(input);

            // Assert
            Assert.Equal(expected, result);
        }

        #endregion Public Methods
    }
}