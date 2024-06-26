using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.IO;

namespace StringExtensions
{
    public static class strExtensions
    {
        public static bool isNumeric(this string input)
        {
            var chars = input.ToList<char>();
            return !(chars.Any(c => !Char.IsNumber(c)));
        }

        //check to see if string decimal is an integer value
        public static bool isInteger(this string input)
        {
            if (input.isNumeric())
            {
                decimal d = input.StrToDecimalDef(0.0M);
                int i = input.StrToIntDef(-1);
                return ((int)Math.Truncate(d) == i);
            }
            else
            {
                return false;
            }
        }
        public static bool isNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }

        public static bool IsNullOrEmptyOrWhiteSpace(this string input)
        {
            return string.IsNullOrEmpty(input) || input.Trim() == string.Empty;
        }
        
        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
        
        public static int StrToInt(this string s)
        {
            int Rtn = -1;
            if (!int.TryParse(s.Trim(), out Rtn))
            {
                Rtn = -1;
            }
            return Rtn;
        }
        public static int StrToIntDef(this string s, int Default)
        {
            int Rtn = Default;
            if (!int.TryParse(s.Trim(), out Rtn))
            {
                Rtn = Default;
            }
            return Rtn;
        }

        public static decimal StrToDecimalDef(this string s, decimal Default)
        {
            decimal Rtn = Default;
            if (!decimal.TryParse(s.Trim(), out Rtn))
            {
                Rtn = Default;
            }
            return Rtn;
        }
        public static double StrToDoubleDef(this string s, double Default)
        {
            double Rtn = Default;
            if (!double.TryParse(s.Trim(), out Rtn))
            {
                Rtn = Default;
            }
            return Rtn;
        }

        public static bool StrToBoolDef(this string s, bool Default)
        {
            bool Rtn = Default;
            if (!string.IsNullOrEmpty(s))
            {
                Rtn = (s.Trim().Length > 0 && s.ToUpper()[0] == 'T'); 
            }
            return Rtn;
        }

        public static DateTime StrToDateTimeDef(this string s, DateTime Default)
        {
            DateTime Rtn = Default;
            if (!DateTime.TryParse(s.Trim(), out Rtn))
            {
                Rtn = Default;
            }
            return Rtn;
        }

        public static DateTime StrToTimeDef(this string s, DateTime Default)
        {
            DateTime Rtn = Default;
            if (!DateTime.TryParse(s.Trim(), out Rtn))
            {
                Rtn = Default;
            }
            else
            {
                Rtn = new DateTime(1900,01,01) + Rtn.TimeOfDay;
            }
            return Rtn;
        }

        public static int NextNonBlank(this string s, int StartPos)
        {
            string cpy = s.Substring(StartPos).TrimStart();
            if (cpy.Length > 0)
            {
                int iRtn = s.IndexOf(cpy[0], StartPos);
                return iRtn;
            }
            else
            {
                return -1;
            }
            
        }

        public static string GetNextNonBlankField(this string s, int StartPos)
        {
            string sRtn = string.Empty;
            int i = s.NextNonBlank(StartPos);
            if (i >= 0)
            {
                string cpy = s.Substring(i);
                int len = cpy.IndexOf(' ');
                if (len > 0)
                {
                    sRtn = cpy.Substring(0,len);
                }
            }
            return sRtn;
        }
        //public static T Parse<T>(this string value)
        //{
        //    // Get default value for type so if string
        //    // is empty then we can return default value.
        //    T result = default(T);
        //    if (!string.IsNullOrEmpty(value))
        //    {
        //        // we are not going to handle exception here
        //        // if you need SafeParse then you should create
        //        // another method specially for that.
        //        TypeConverter tc = TypeDescriptor.GetConverter(typeof(T));
        //        result = (T)tc.ConvertFrom(value);
        //    } return result;
        //}


        public static bool ContainsNumericChars(this string s)
        {
            return s.IndexOfAny("0123456789".ToArray()) >= 0;
        }

        public static bool IsDate(this string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                DateTime dt;
                return (DateTime.TryParse(input, out dt));
            }
            else
            {
                return false;
            }
        }

        public static bool In(this string Value, params string[] ValuesToCompare)
        {
            bool IsIn = false;
            foreach (string ValueToCompare in ValuesToCompare)
            {
                if (Value == ValueToCompare)
                {
                    IsIn = true;
                }
            }
            return IsIn;
        }

        public static bool EqualsAny(this string str, params string[] args)
        {
            return args.Any(x =>
              StringComparer.InvariantCultureIgnoreCase.Equals(x, str));
        }

        public static bool IsValidEmailAddress(this string s)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(s);
        }

        /// <example>
        /// string path = new[] { s1, s2, s3 }.PathCombine();
        /// </example>
        public static string PathCombine(this IEnumerable<string> pathParts)
        {
            string joinedPath = string.Empty;
            foreach (string pathPart in pathParts)
                joinedPath = Path.Combine(joinedPath, pathPart);
            return joinedPath;

        }

        public static string StrWOLeadingZeros(this string s)
        {
            return Regex.Replace(s.Trim(), "^(.*?)0+", "$1");
        }
        public static string StrWOLeadingZerosOrDash(this string s)
        {
            string sNew = Regex.Replace(s.Trim(), "^(.*?)0+", "$1");
            return sNew.Replace("-", "");
        }
        public static bool StrMatchSignificantChars(this string s, string sMatch)
        {
            string strippeds = s.StrWOLeadingZerosOrDash();
            string stripMatch = sMatch.StrWOLeadingZerosOrDash(); //(Regex.Replace(sMatch.Trim(), "^(.*?)0+", "$1");
            return (strippeds == stripMatch);
        }

        public static string ReplaceNonNumericWithDash(this string s)
        {
            string Rtn = string.Empty;
            foreach (char c in s.ToCharArray())
            {
                if (Char.IsNumber(c))
                {
                    Rtn += c;
                }
                else
                {
                    Rtn += "-";
                }
            }
            return Rtn;
        }
        public static string ReverseCharOrder(this string str)
        {
            string Rslt = string.Empty;
            foreach (char c in str)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    char c2 = (char)((byte)('A') + (((byte)('Z')) - (byte)(c)));
                    Rslt += c2;
                }
                else
                {
                    if (c >= 'a' && c < +'z')
                    {
                        char c2 = (char)((byte)('a') + (((byte)('z')) - (byte)(c)));
                        Rslt += c2;
                    }
                    else
                    {
                        if (c >= '0' && c <= '9')
                        {
                            char c2 = (char)((byte)('0') + (((byte)('9')) - (byte)(c)));
                            Rslt += c2;
                        }
                        else
                        {
                            Rslt += c;
                        }
                    }

                }
            }
            return Rslt;
        }
    }
}
