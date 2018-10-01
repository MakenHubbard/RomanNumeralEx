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
