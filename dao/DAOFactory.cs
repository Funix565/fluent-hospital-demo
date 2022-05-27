using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4NHibernateIndividual.dao
{
    // Abstract factory for specific DAOs
    public abstract class DAOFactory
    {
        public abstract IDoctorDAO GetDoctorDAO();
        public abstract IPatientDAO GetPatientDAO();
        public abstract IConsultationDAO GetConsultationDAO();
    }
}
