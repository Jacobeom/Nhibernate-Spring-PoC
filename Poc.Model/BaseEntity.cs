using NHibernate.Mapping.Attributes;
using Poc.Configuration.Auditory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Model
{
    public abstract class BaseEntity : IAuditable
    {
        protected BaseEntity()
        {
            AuditInfo = new Auditable();
        }


        [Id(Name = "Id", TypeType = typeof(int))]
        [Generator(1, Class = "native")]
        public virtual int? Id { get; set; }

        [ComponentProperty]
        public virtual Auditable AuditInfo { get; set; }

    }
}
