using System;
using Xunit;
using RomanNumeralEx;


namespace RomanNumeral.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(7, "VII")]
        [InlineData(10, "X")]
        [InlineData(9,"IX")]

        public void One_through_12_will_show_in_roman_numeral(int arabicNum, string romanNum)
        {
            //Act
            
            var converter = new Converter();
            var result = converter.ConversionMethod(arabicNum);

            //Assert
            Assert.Equal(romanNum,result);
        }
    }
}
