using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counterMulti.Resource
{
    public class WordtoNum
    {
        public double WordtoNumb(string wordnum)
        {
            if (string.IsNullOrEmpty(wordnum)) return 0;

            wordnum = wordnum.Trim();
            wordnum += ' ';

            double number = 0;
            string[] singles = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] teens = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = new string[] { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninty" };
            string[] powers = new string[] { "", "thousand", "million", "billion", "trillion", "quadrillion", "quintillion" };

            for (int i = powers.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(powers[i]))
                {
                    int index = wordnum.IndexOf(powers[i]);

                    if (index >= 0 && wordnum[index + powers[i].Length] == ' ')
                    {
                        double count = WordtoNumb(wordnum.Substring(0, index));
                        number += count * (double)Math.Pow(1000, i);
                        wordnum = wordnum.Remove(0, index);
                    }
                }
            }

            {
                int index = wordnum.IndexOf("hundred");

                if (index >= 0 && wordnum[index + "hundred".Length] == ' ')
                {
                    double count = WordtoNumb(wordnum.Substring(0, index));
                    number += count * 100;
                    wordnum = wordnum.Remove(0, index);
                }
            }

            for (int i = tens.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(tens[i]))
                {
                    int index = wordnum.IndexOf(tens[i]);

                    if (index >= 0 && wordnum[index + tens[i].Length] == ' ')
                    {
                        number += (uint)(i * 10);
                        wordnum = wordnum.Remove(0, index);
                    }
                }
            }

            for (int i = teens.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(teens[i]))
                {
                    int index = wordnum.IndexOf(teens[i]);

                    if (index >= 0 && wordnum[index + teens[i].Length] == ' ')
                    {
                        number += (uint)(i + 10);
                        wordnum = wordnum.Remove(0, index);
                    }
                }
            }

            for (int i = singles.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(singles[i]))
                {
                    int index = wordnum.IndexOf(singles[i] + " ");

                    if (index >= 0 && wordnum[index + singles[i].Length] == ' ')
                    {
                        number += (uint)(i);
                        wordnum = wordnum.Remove(0, index);
                    }
                }
            }
            return number;
        }
    }
}
