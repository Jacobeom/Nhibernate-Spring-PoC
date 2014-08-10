using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Configuration.Auditory
{
    public interface IAuditable
    {
        Auditable AuditInfo { get; set; }
    }
}
