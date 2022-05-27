using Lab4NHibernateIndividual.domain;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4NHibernateIndividual.dao
{
    // Dummy class just so we don't call Generic to interact with Consultation
    public class ConsultationDAO : GenericDAO<Consultation>, IConsultationDAO
    {
        public ConsultationDAO(ISession session) : base(session) { }
    }
}
