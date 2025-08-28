using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKATAs.Solutions
{
    public class Parser
    {


        public static int ParseInt(string s)
        {
            Dictionary<string, int> Numbers = new Dictionary<string, int>
            {
                {"zero", 0}, {"one", 1}, {"two", 2}, {"three", 3}, {"four", 4},
                {"five", 5}, {"six", 6}, {"seven", 7}, {"eight", 8}, {"nine", 9},
                {"ten", 10}, {"eleven", 11}, {"twelve", 12}, {"thirteen", 13}, {"fourteen", 14},
                {"fifteen", 15}, {"sixteen", 16}, {"seventeen", 17}, {"eighteen", 18}, {"nineteen", 19},
                {"twenty", 20}, {"thirty", 30}, {"forty", 40}, {"fifty", 50},
                {"sixty", 60}, {"seventy", 70}, {"eighty", 80}, {"ninety", 90}
            };
            s = s.Replace("-", " ").Replace(" and ", " ");
            string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int total = 0;
            int current = 0;

            foreach (var word in words)
            {
                if (Numbers.ContainsKey(word))
                {
                    current += Numbers[word];
                }
                else if (word == "hundred")
                {
                    current *= 100;
                }
                else if (word == "thousand")
                {
                    total += current * 1000;
                    current = 0;
                }
                else if (word == "million")
                {
                    total += current * 1000000;
                    current = 0;
                }
            }

            return total + current;
        }


        public static int ParseInt2(string s)
        {
            Dictionary<string, int> zeroToNine = new Dictionary<string, int>() {
                { "zero", 0 }, { "one", 1 }, { "two", 2 }, { "three", 3 },
                { "four", 4 }, { "five", 5 }, { "six", 6 }, { "seven", 7 },
                { "eight", 8 }, { "nine", 9 }
            };

            Dictionary<string, int> tenToNineteen = new Dictionary<string, int>() {
                { "ten", 10 }, { "eleven", 11 }, { "tvelve", 12 }, { "thirteen", 13 }, { "fourteen", 14 },
                { "fifteen", 15 }, { "sixteen", 16 }, { "seventeen", 17 }, { "eightenn", 18 },
                { "nineteen", 19 }
            };

            Dictionary<string, int> tens = new Dictionary<string, int>() {
                { "twenty", 20 }, { "thirty", 30 }, { "forty", 40 }, { "fifty", 50 }, { "sixty", 60 },
                { "seventy", 70 }, { "eighty", 80 }, { "ninety", 90 }
            };

            Dictionary<string, int> multiplyers = new Dictionary<string, int>() {
                { "hundred", 100 }, { "thousand", 1000 }, { "and", 1 }, { "million", 1000000 }
            };

            int result = 0;

            string[] parts = s.Split(' ');

            for (int i = 0; i < parts.Length; i++)
            //for (int i = parts.Length - 1; i >= 0; i--)
            {
                int rrrrrrrr = result;
                string kkkkkkk = parts[i];
                if (parts[i].Contains("-"))
                {
                    string[] numbers = parts[i].Split("-");

                    if (i != parts.Length - 1 && multiplyers.ContainsKey(parts[i + 1]))
                    {
                        if (i + 1 != parts.Length - 1 && multiplyers.ContainsKey(parts[i + 2]))
                        {
                            result += (tens[numbers[0]] + zeroToNine[numbers[1]]) * multiplyers[parts[i + 1]] * multiplyers[parts[i + 2]];
                        }
                        else
                        {
                            result += (tens[numbers[0]] + zeroToNine[numbers[1]]) * multiplyers[parts[i + 1]];
                            i++;
                        }
                    }
                    else
                    {
                        result += tens[numbers[0]] + zeroToNine[numbers[1]];
                    }
                }
                else if (tenToNineteen.ContainsKey(parts[i]))
                {

                    if (i != parts.Length - 1 && multiplyers.ContainsKey(parts[i] + 1))
                    {
                        if (i + 1 != parts.Length - 1 && multiplyers.ContainsKey(parts[i + 2]))
                        {
                            result += tenToNineteen[parts[i]] * multiplyers[parts[i + 1]] * multiplyers[parts[i + 2]];
                        }
                        else
                        {
                            result += tenToNineteen[parts[i]] * multiplyers[parts[i + 1]];
                            i++;
                        }
                        
                    }
                    else
                    {
                        result += tenToNineteen[parts[i]];
                    }
                }
                else if (zeroToNine.ContainsKey(parts[i]))
                {
                    if (i != parts.Length - 1 && multiplyers.ContainsKey(parts[i + 1]))
                    {
                        if (i + 1 != parts.Length - 1 && multiplyers.ContainsKey(parts[i + 2]))
                        {
                            result += zeroToNine[parts[i]] * multiplyers[parts[i + 1]] * multiplyers[parts[i + 2]];
                        }
                        else
                        {
                            result += zeroToNine[parts[i]] * multiplyers[parts[i + 1]];
                            i++;
                        }
                    }
                    else
                    {
                        result += zeroToNine[parts[i]];
                    }
                }
                else if (tens.ContainsKey(parts[i])) 
                {

                    if (i != parts.Length - 1 && multiplyers.ContainsKey(parts[i] + 1))
                    {
                        if (i + 1 != parts.Length - 1 && multiplyers.ContainsKey(parts[i + 2]))
                        {
                            result += tens[parts[i]] * multiplyers[parts[i + 1]] * multiplyers[parts[i + 2]];
                        }
                        else
                        {
                            result += tens[parts[i]] * multiplyers[parts[i + 1]];
                            i++;
                        }

                    }
                    else
                    {
                        result += tens[parts[i]];
                    }
                }
                //else if (multiplyers.ContainsKey(parts[i]))
                //{
                //    result *= multiplyers[parts[i]];
                //}
            }

            return result;
        }
    }
}
