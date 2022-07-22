using LeetCode_14_LongestCommonPrefix;

namespace UnitTests
{
    public class ProvideArrayOfStrings
    {
        [Theory]
        [InlineData(new string[] { "", "" }, "")]
        [InlineData(new string[] { "a", "" }, "")]
        [InlineData(new string[] { "", "b" }, "")]
        [InlineData(new string[] { "a", "b" }, "")]
        [InlineData(new string[] { "aa", "ab" }, "a")]
        [InlineData(new string[] { " ", "" }, "")]
        [InlineData(new string[] { "", " " }, "")]
        [InlineData(new string[] { " ", " " }, " ")]
        [InlineData(new string[] { "  ", "  " }, "  ")]
        [InlineData(new string[] { "   ", "  " }, "  ")]
        [InlineData(new string[] { "aaa", "aba" }, "a")]
        [InlineData(new string[] { "aaa", "aab" }, "aa")]
        [InlineData(new string[] { "aaa", "aaa" }, "aaa")]
        [InlineData(new string[] { "aaabcd", "aaa" }, "aaa")]
        [InlineData(new string[] { "aaabcd", "aaadef" }, "aaa")]
        [InlineData(new string[] { "aaabcd", "aaabef" }, "aaab")]
        [InlineData(new string[] { "aaabcd", "aaabef", "aaaghi" }, "aaa")]
        [InlineData(new string[] { "aaabcd", "aaabef", "aaabhi" }, "aaab")]
        [InlineData(new string[] { "aaabcd", "aaabef", "" }, "")]
        [InlineData(new string[] { "aaabcd", "aaabef", "aa" }, "aa")]
        [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
        public void ReturnsLongestCommonPrefix(string[] strArray, string expectedResult)
        {
            // Arrange

            // Act
            string actualResult = new Class1().LongestCommonPrefix(strArray);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ThrowsConstraintViolationExceptionWhenAnInputStringIsTooLong()
        {
            // Arrange
            //      Create a string whose length is 201 characters
            string[] strArray = new string[] { "111111111122222222223333333333444444444455555555556666666666777777777788888888889999999999000000000011111111112222222222333333333344444444445555555555666666666677777777778888888888999999999900000000001" };

            // Act
            Action action = () => new Class1().LongestCommonPrefix(strArray);

            // Assert
            Assert.Throws<ConstraintViolationException>(action);
        }

        [Fact]
        public void ThrowsConstraintViolationExceptionWhenThereAreTooManyOrTooFewInputStrings()
        {
            // Arrange

            //      ...too few input strings
            string[] strArray1 = new string[] { };
            //      ...too many input strings
            string[] strArray2 = new string[] {
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "11", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "21", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "31", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "41", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "51", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "61", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "71", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "81", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "91", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "101", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "111", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "121", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "131", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "141", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "151", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "161", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "171", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "181", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "191", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "201"
            };

            // Act
            Action action1 = () => new Class1().LongestCommonPrefix(strArray1);
            Action action2 = () => new Class1().LongestCommonPrefix(strArray2);

            // Assert
            Assert.Throws<ConstraintViolationException>(action1);
            Assert.Throws<ConstraintViolationException>(action2);
        }

        [Theory]
        [InlineData(new string[] { "A" }, "")]
        [InlineData(new string[] { "1" }, "")]
        [InlineData(new string[] { "#" }, "")]
        [InlineData(new string[] { "a", "A" }, "")]
        [InlineData(new string[] { "a", "1" }, "")]
        [InlineData(new string[] { "a", "#" }, "")]
        [InlineData(new string[] { "a", "b", "A" }, "")]
        [InlineData(new string[] { "a", "a", "A" }, "")]
        [InlineData(new string[] { "a", "a", "aA" }, "")]
        [InlineData(new string[] { "a", "a", "abA" }, "")]
        [InlineData(new string[] { "a", "a1", "aA" }, "")]
        [InlineData(new string[] { "a#", "a", "a" }, "")]
        public void ThrowsConstraintViolationExceptionWhenAnInputStringContainsInvalidCharacters(string[] strArray, string dummyParam)
        {
            // Arrange

            // Act
            Action action = () => new Class1().LongestCommonPrefix(strArray);

            // Assert
            Assert.Throws<ConstraintViolationException>(action);
        }
    }
}