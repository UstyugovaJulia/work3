using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work3_2
{
    public class ZeroTasknameException : ApplicationException
    {
        public ZeroTasknameException(string message) : base(message)
        {
        }
    }
}
