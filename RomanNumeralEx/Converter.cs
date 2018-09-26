using System;


namespace RomanNumeralEx
{
    public class Converter 
    {
        public string ConversionMethod(int arabicNum)
        {
            if (arabicNum < 4)
            {
                var romanNumString = new System.Text.StringBuilder();
                for(int i = 0; i < arabicNum; i++)
                {
                    romanNumString.Append("I");
                }
                return romanNumString.ToString();
            }

            else if (arabicNum == 5)
            {
                return "V";
            }

            throw new Exception();

            
        }
    }
}
