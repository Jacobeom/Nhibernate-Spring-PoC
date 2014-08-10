using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Model
{
    [NHibernate.Mapping.Attributes.Class(Where = "IsDeleted = 0")]
    public class LoginSession : BaseEntity
    {
        [ManyToOne(Column = "LoginId", NotNull = true)]
        public virtual Login Login { get; set; }

        [Property(NotNull = true)]
        public virtual Guid SessionGuid { get; set; }

    }
}
