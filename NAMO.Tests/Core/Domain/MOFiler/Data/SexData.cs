using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Tests.Core.Domain.MOFiler.Data
{
    public class SexData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "M" }; //Английский
            yield return new object[] { "m" }; //Английский
            yield return new object[] { "М" }; //Русский
            yield return new object[] { "м" }; //Русский
            yield return new object[] { "MALE" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
