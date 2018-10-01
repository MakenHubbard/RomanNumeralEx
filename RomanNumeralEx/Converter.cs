using System;
using System.Collections.Generic;

namespace RomanNumeralEx
{
    public class Converter
    {
        Dictionary<int, string> arabToRoman = new Dictionary<int, string>();

        public string ConversionMethod(int arabicNum)
        {
           
            var romanNumeral = "";

            while(arabicNum > 0)
            {
                if (arabicNum >= 1000)
                {
                    romanNumeral += "M";
                    arabicNum -= 1000;
                }

                else if (arabicNum >= 900)
                {
                    romanNumeral += "CM";
                    arabicNum -= 900;
                }

                else if (arabicNum >= 500)
                {
                    romanNumeral += "D";
                    arabicNum -= 500;
                }

                else if (arabicNum >= 400)
                {
                    romanNumeral += "CD";
                    arabicNum -= 400;
                }

                else if (arabicNum >= 100)
                {
                    romanNumeral += "C";
                    arabicNum -= 100;
                }

                else if (arabicNum >= 90)
                {
                    romanNumeral += "XC";
                    arabicNum -= 90;
                }

                else if (arabicNum >= 50)
                {
                    romanNumeral += "L";
                    arabicNum -= 50;
                }

                else if (arabicNum >= 40)
                {
                    romanNumeral += "XL";
                    arabicNum -= 40;
                }

                else if (arabicNum >= 10)
                {
                    romanNumeral += "X";
                    arabicNum -= 10;
                }

                else if (arabicNum == 9)
                {
                    romanNumeral += "IX";
                    arabicNum -= 9;
                }

                else if(arabicNum >= 5)
                {
                    romanNumeral += "V";
                    arabicNum -= 5;
                }

                else if (arabicNum == 4)
                {
                    romanNumeral += "IV";
                    arabicNum -= 4;
                }

                else if (arabicNum >= 1)
                {
                    romanNumeral += "I";
                    arabicNum -= 1;
                }
            }

            return romanNumeral;

        }
    }
}
