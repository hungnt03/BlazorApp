using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Shared.Commons
{
    public static class StringUtil
    {
        public const string USER_KEY = "user";

        public static bool IsNumberic(string value)
        {
            return value.All(char.IsNumber);
        }

        public static string ToCurrency(int value)
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
            return double.Parse(value.ToString()).ToString("#,###", cul.NumberFormat);
        }
    }
}
