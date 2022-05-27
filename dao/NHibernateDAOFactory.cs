using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4NHibernateIndividual.dao
{
    // Concrete Factory for our DAOs
    public class NHibernateDAOFactory : DAOFactory
    {
        protected ISession session;

        public NHibernateDAOFactory(ISession session)
        {
            this.session = session;
        }

        public override IDoctorDAO GetDoctorDAO()
        {
            return new DoctorDAO(session);
        }

        public override IPatientDAO GetPatientDAO()
        {
            return new PatientDAO(session);
        }

        public override IConsultationDAO GetConsultationDAO()
        {
            return new ConsultationDAO(session);
        }
    }
}
