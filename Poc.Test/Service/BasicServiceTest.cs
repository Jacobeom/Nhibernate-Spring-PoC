using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;
using NUnit.Framework;
using Poc.Configuration.Identity;
using Poc.Configuration.SchemaGeneration;
using Poc.Model;
using Poc.Service;
using Spring.Testing.NUnit;

namespace Poc.Test.Service
{
    [TestFixture]
    public abstract class BaseServiceTest<T> : AbstractDependencyInjectionSpringContextTests where T : BaseEntity
    {
        public IBasicService<T> BasicService { get; set; }

        public ISchemaGeneration SchemaGeneration { get; set; }

        public BaseServiceTest()
        {
            XmlConfigurator.Configure();
        }

        protected override void OnSetUp()
        {
            base.OnSetUp();
            SchemaGeneration.GenerateDatabase();
            ThreadIdentity.SetCurrentThreadIdentity("Test Identity");
        }

        protected override string[] ConfigLocations
        {
            get
            {
                return new string[]
                           {
                               "assembly://Poc.Service/Poc.Service/Service.xml",
                               "config://spring/objects"
                           };
            }
        }
    }
}
