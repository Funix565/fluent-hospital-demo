using Lab4NHibernateIndividual.domain;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4NHibernateIndividual.dao
{
    // Concrete DAO for Patient with implementation of specific methods
    public class PatientDAO : GenericDAO<Patient>, IPatientDAO
    {
        public PatientDAO(ISession session) : base(session) { }

        public Patient GetPatientByDoctorAndInsuranceId(string doctorName, int insuranceId)
        {
            string query = $@"SELECT patient.* FROM patient JOIN doctor ON patient.doctor_id = doctor.id WHERE doctor.doctorname = '{doctorName}' AND patient.insuranceid = '{insuranceId}'";

            ISQLQuery q = session.CreateSQLQuery(query).AddEntity("Patient", typeof(Patient));

            return q.List<Patient>()[0];
        }

        public Patient GetPatientByInsuranceId(int insuranceId)
        {
            string query = $@"SELECT patient.* FROM patient WHERE patient.insuranceid = '{insuranceId}'";

            ISQLQuery q = session.CreateSQLQuery(query).AddEntity("Patient", typeof(Patient));

            return q.List<Patient>()[0];
        }

        public IList<Consultation> GetAllConsultationsOfPatient(Patient patient)
        {
            // Verbatim string (w/o escape) with interpolation (vars inside)
            //string query = $@"SELECT consultation.* FROM consultation JOIN patient ON consultation.patient_id = patient.id WHERE patient.patientname = '{patientName}'";
            //return session.CreateSQLQuery(query).AddEntity("Consultation", typeof(Consultation)).List<Consultation>();

            return patient.ConsultationList;
        }
    }
}
