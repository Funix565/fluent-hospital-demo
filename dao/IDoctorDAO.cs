using Lab4NHibernateIndividual.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4NHibernateIndividual.dao
{
    // Specific interface for Doctor
    public interface IDoctorDAO : IGenericDAO<Doctor>
    {
        Doctor GetDoctorByName(string doctorName);
        IList<Patient> GetAllPatientsOfDoctor(string doctorName);
        void DeleteDoctorByName(string doctorName);
        IList<Consultation> GetAllConsultationsOfDoctor(Doctor entity);
    }
}
