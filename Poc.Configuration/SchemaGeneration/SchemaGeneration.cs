using NHibernate.Tool.hbm2ddl;
using Spring.Data.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Configuration.SchemaGeneration
{
    public class SchemaGeneration : ISchemaGeneration
    {
        public LocalSessionFactoryObject LocalSessionFactoryObject { get; set; }

        public void GenerateDatabase()
        {
            SchemaExport schemaExport = new NHibernate.Tool.hbm2ddl.SchemaExport(LocalSessionFactoryObject.Configuration);

            schemaExport.Create(true, true);

        }

    }
}
