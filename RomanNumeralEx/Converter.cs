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

            else if (arabicNum > 5 && arabicNum < 9)
            {
                var romanNumString = new System.Text.StringBuilder("V");
                
                for(int i = 5; i < arabicNum; i++)
                {
                    romanNumString.Append("I");
                }
                return romanNumString.ToString();
            }

            else if (arabicNum == 10)
            {
                return "X";
            }

            throw new Exception();

            
        }
    }
}
