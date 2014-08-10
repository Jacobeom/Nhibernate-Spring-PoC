using NHibernate.Event;
using Poc.Configuration.Auditory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NHibernate.Persister.Entity;

namespace Poc.Configuration.EventListener
{
    public class DeleteEventListener : NHibernate.Event.Default.DefaultDeleteEventListener
    {

        protected override void DeleteEntity(IEventSource session, object entity, NHibernate.Engine.EntityEntry entityEntry, bool isCascadeDeleteEnabled, IEntityPersister persister, Iesi.Collections.ISet transientEntities)
        {
            if (entity is IAuditable)
            {
                IAuditable audit = entity as IAuditable;
                audit.AuditInfo.IsDeleted = true;
                audit.AuditInfo.ModificationDate = DateTime.UtcNow;
                audit.AuditInfo.ModificationUser = Thread.CurrentPrincipal.Identity.Name;
                CascadeBeforeDelete(session, persister, entity, entityEntry, transientEntities);
                CascadeAfterDelete(session, persister, entity, transientEntities);
            }
            else
            {
                base.DeleteEntity(session, entity, entityEntry, isCascadeDeleteEnabled, persister, transientEntities);
            }
        }

    }
}
