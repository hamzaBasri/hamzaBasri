using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rosa.Extentions

{
    public static class MyEncoder
    {

        private const string digitsStr =
            "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz+-";

        private static readonly Dictionary<char, int> digitsMap = new Dictionary<char, int>();

        static MyEncoder()
        {
            for (int i = 0; i < digitsStr.Length; i++)
            {
                digitsMap.Add(digitsStr[i], i);
            }
        }


        public static string EncodeFromInt(this int number)
        {
            var result = "";
            while (true)
            {
                result = digitsStr[number & 0x3f] + result;
                number = (int)((uint)number >> 6);
                if (number == 0)
                    break;
            }
            return result;
        }

        public static int DecodeToInt(this string code)
        {
            var result = 0;
            for (int i = 0; i < code.Length; i++)
            {
                result = (result << 6) + digitsMap[code[i]];
            }
            return result;

        }


    }

}
