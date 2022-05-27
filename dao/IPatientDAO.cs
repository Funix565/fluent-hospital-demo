using Lab4NHibernateIndividual.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4NHibernateIndividual.dao
{
    // Specific interface for Patient
    public interface IPatientDAO :IGenericDAO<Patient>
    {
        Patient GetPatientByDoctorAndInsuranceId(string doctorName, int insuranceId);
        Patient GetPatientByInsuranceId(int insuranceId);
        IList<Consultation> GetAllConsultationsOfPatient(Patient entity);
    }
}
