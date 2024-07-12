using NAMO.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Tests.Core.Domain.SnilsComparator.Data
{
    public class SnilsValidData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                //Есть только ФИО + ДР
                new SnilsData
                {
                    SNILS1 = "151-944-680 79",
                    SNILS2 = "151-944-680 79",
                }
            };

            yield return new object[]
            {
                //Есть только ФИО + ДР
                new SnilsData
                {
                    SNILS1 = "151944-680 79",
                    SNILS2 = "151-944-68079",
                }
            };

            yield return new object[]
            {
                //Есть только ФИО + ДР
                new SnilsData
                {
                    SNILS1 = "15194468079",
                    SNILS2 = "151-944-680 79",
                }
            };

            yield return new object[]
            {
                //Есть только ФИО + ДР
                new SnilsData
                {
                    SNILS1 = "151-944-680 79",
                    SNILS2 = "15194468079",
                }
            };

            yield return new object[]
            {
                //Есть только ФИО + ДР
                new SnilsData
                {
                    SNILS1 = "151944-68079",
                    SNILS2 = "151-94468079",
                }
            };

            yield return new object[]
            {
                //Есть только ФИО + ДР
                new SnilsData
                {
                    SNILS1 = "ф151944-68079",
                    SNILS2 = "151-944680d79",
                }
            };

            yield return new object[]
            {
                //Есть только ФИО + ДР
                new SnilsData
                {
                    SNILS1 = "151944-68079df",
                    SNILS2 = "151-wer9446sdf8079",
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}