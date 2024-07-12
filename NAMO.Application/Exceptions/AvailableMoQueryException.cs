using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Application.Exceptions
{
    public class AvailableMoQueryException : Exception
    {
        public AvailableMoQueryException():base() 
        { 
        }

        public AvailableMoQueryException(string message) : base(message)
        {
        }
    }
}
