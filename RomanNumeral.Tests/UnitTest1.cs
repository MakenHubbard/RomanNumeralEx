using System;
using Xunit;
using RomanNumeralEx;


namespace RomanNumeral.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(5, "V")]
        [InlineData(7, "VII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(12, "XII")]
        [InlineData(16, "XVI")]
        [InlineData(29, "XXIX")]
        [InlineData(44, "XLIV")]
        [InlineData(45, "XLV")]
        [InlineData(68, "LXVIII")]
        [InlineData(83, "LXXXIII")]
        [InlineData(97, "XCVII")]
        [InlineData(99, "XCIX")]
        [InlineData(469, "CDLXIX")]
        [InlineData(500, "D")]
        [InlineData(501, "DI")]
        [InlineData(649, "DCXLIX")]
        [InlineData(798, "DCCXCVIII")]
        [InlineData(891, "DCCCXCI")]
        [InlineData(967, "CMLXVII")]
        [InlineData(1000, "M")]
        [InlineData(1004, "MIV")]
        [InlineData(1023, "MXXIII")]
        [InlineData(2014, "MMXIV")]
        [InlineData(3999, "MMMCMXCIX")]

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
