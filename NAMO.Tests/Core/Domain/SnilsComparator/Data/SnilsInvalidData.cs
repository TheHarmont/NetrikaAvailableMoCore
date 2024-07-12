using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Tests.Core.Domain.SnilsComparator.Data
{
    public class SnilsInvalidData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                //Есть только ФИО + ДР
                new SnilsData
                {
                    SNILS1 = "",
                    SNILS2 = "",
                }
            };

            yield return new object[]
            {
                //Есть только ФИО + ДР
                new SnilsData
                {
                    SNILS1 = "1151-944-680 79",
                    SNILS2 = "15194468079d",
                }
            };

            yield return new object[]
            {
                //Есть только ФИО + ДР
                new SnilsData
                {
                    SNILS1 = "1519468079",
                    SNILS2 = "151-94468079",
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
