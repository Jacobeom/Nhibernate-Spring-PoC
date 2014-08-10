using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poc.Configuration
{
    public class CustomSessionFactoryObject : Spring.Data.NHibernate.LocalSessionFactoryObject
    {
        public string[] AnnotatedMappingAssemblies { set; get; }

        protected override void PostProcessConfiguration(NHibernate.Cfg.Configuration config)
        {
            base.PostProcessConfiguration(config);
            CustomNHibernateConfigurator.ConfigureMappingsAndEventListeners(config, AnnotatedMappingAssemblies);
        }
    }
}
