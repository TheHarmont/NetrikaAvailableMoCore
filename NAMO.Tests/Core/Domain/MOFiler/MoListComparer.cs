using NAMO.Domain.Entities.dbEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Tests.Core.Domain.MOFiler
{
    public class MoListComparer : IEqualityComparer<MO>
    {
        public bool Equals(MO x, MO y)
        {
            if (x == null && y == null)
                return true;
            if (x == null || y == null)
                return false;

            return x.OrdId == y.OrdId;
        }

        public int GetHashCode(MO obj)
        {
            return HashCode.Combine(obj.OrdId);
        }
    }
}
