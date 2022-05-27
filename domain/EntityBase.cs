using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4NHibernateIndividual.domain
{
    public abstract class EntityBase
    {
        // It's only NHibernate that should be setting the value of that Id
        // virtual - because NHibernate creates "proxies" to allow for lazy loading
        public virtual long Id { get; protected set; }
    }
}
