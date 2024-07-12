using System.Collections;

namespace NAMO.Tests.Core.Domain.MOFiler.Data
{
    public class BirthData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "18.06.2000" };
            yield return new object[] { "2000-06-18" };
            yield return new object[] { "June 18, 2000" };
            yield return new object[] { "18-Jun-2000" };
            yield return new object[] { "2000.06.18" };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
