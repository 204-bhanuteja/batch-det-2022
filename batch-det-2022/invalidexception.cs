using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp
{
    public class invalidexception : Exception
    { 
        public invalidexception (String msg):base(msg)
    {
    }
}
}