using System;
using System.Collections.Generic;

namespace RomanNumeralEx
{
    public class Converter
    {
        Dictionary<int, string> arabToRoman = new Dictionary<int, string>();

        public string ConversionMethod(int arabicNum)
        {
            arabToRoman.Add(1, "I");
            arabToRoman.Add(5, "V");
            arabToRoman.Add(10, "X");
            arabToRoman.Add(50, "L");
            arabToRoman.Add(100, "C");
            arabToRoman.Add(500, "D");
            arabToRoman.Add(1000, "M");

            var romanNumeral = "";

            while(arabicNum > 0)
            {
                if (arabicNum >= 10)
                {
                    romanNumeral += "X";
                    arabicNum -= 10;
                }

                if(arabicNum >= 5)
                {
                    romanNumeral += "V";
                    arabicNum -= 5;
                }

                else if (arabicNum >= 1)
                {
                    romanNumeral += "I";
                    arabicNum -= 1;
                }
            }

            return romanNumeral;

            //if (arabicNum < 4)
            //{
            //    var romanNumString = new System.Text.StringBuilder();
            //    for (int i = 0; i < arabicNum; i++)
            //    {
            //        romanNumString.Append("I");
            //    }
            //    return romanNumString.ToString();
            //}

            //else if (arabicNum == 5)
            //{
            //    return "V";
            //}

            //else if (arabicNum > 5 && arabicNum < 9)
            //{
            //    var romanNumString = new System.Text.StringBuilder("V");

            //    for (int i = 5; i < arabicNum; i++)
            //    {
            //        romanNumString.Append("I");
            //    }
            //    return romanNumString.ToString();
            //}

            //else if (arabicNum == 10)
            //{
            //    return "X";
            //}

            //else if (arabicNum == 9)
            //{
            //    var romanNumString = new System.Text.StringBuilder("X");

            //    for (int i = 8; i < arabicNum; i++)
            //    {
            //        romanNumString.Insert(0, "I");
            //    }
            //    return romanNumString.ToString();
            //}

            //else if (arabicNum > 10 && arabicNum < 15)
            //{
            //    var romanNumString = new System.Text.StringBuilder("X");

            //    for (int i = 10; i < arabicNum; i++)
            //    {
            //        romanNumString.Append("I");
            //    }
            //    return romanNumString.ToString();
            //}

            //else if (arabicNum > 15)
            //{
            //    var romanNumString = new System.Text.StringBuilder("XV");

            //    for (int i = 15; i < arabicNum; i++)
            //    {
            //        romanNumString.Append("I");
            //    }
            //    return romanNumString.ToString();
            //}

            //else if (arabicNum == 20)
            //{

            //}

            //throw new Exception();


        }
    }
}
