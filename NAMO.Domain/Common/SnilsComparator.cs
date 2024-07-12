using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Domain.Common
{
    public static class SnilsComparator
    {
        /// <summary>
        /// Сравнивает 2 СНИЛСа
        /// </summary>
        /// <returns>true если равны</returns>
        public static bool SnilsEquals(this string? snils1, string? snils2)
        {
            if (string.IsNullOrEmpty(snils1) || string.IsNullOrEmpty(snils2)) return false;

            snils1 = new string(snils1.Where(c => char.IsDigit(c)).ToArray());
            snils2 = new string(snils2.Where(c => char.IsDigit(c)).ToArray());

            return string.Equals(snils1, snils2, StringComparison.Ordinal);
        }
    }
}
