using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AzDecimalConverter
{
    public static class NumericHelper
    {
        public static string ToAzDecimal(this long value, bool caseSensitive = true)
        {
            if (value == 0) return "0";

            string s = "";
            byte dec = (byte)(caseSensitive ? 62 : 36);

            while (value != 0)
            {
                long rem = value / dec;
                byte asc = Convert.ToByte(dec * (((decimal)value / (decimal)dec) - rem));
                value = rem;
                if (asc < 10) asc += 48; else if (asc < 36) asc += 55; else asc += 61;

                s = (char)asc + s;
            }

            return s;
        }
    }
}
