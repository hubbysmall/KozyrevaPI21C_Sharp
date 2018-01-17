using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3sharpNEW
{
    class PortAlreadyHaveException : Exception
    {
        public PortAlreadyHaveException():base("такая уже есть"){ }
    
    }
}
