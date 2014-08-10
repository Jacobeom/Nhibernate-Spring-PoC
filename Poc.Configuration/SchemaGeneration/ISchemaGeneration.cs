using Spring.Data.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Configuration.SchemaGeneration
{
    public interface ISchemaGeneration
    {
        LocalSessionFactoryObject LocalSessionFactoryObject { get; set; }
        void GenerateDatabase();
    }
}
