using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Protocols
{
    interface IResponse
    {
        List<byte> pyld { get; }
        string mime { get; }
        string encoding { get; }
    }
}
