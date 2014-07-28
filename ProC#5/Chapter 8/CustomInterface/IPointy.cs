using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    // This interface defines the behaviour of "having points"
    interface IPointy
    {
        // A read-write property behavior as a read-only property
        // retType PropName { get; set; }
        // Below is an example of a read-only property
        byte Points { get; }
    }
}
