using Lab4NHibernateIndividual.domain;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4NHibernateIndividual.dao
{
    // Concrete DAO for Doctor with implementation of specific methods
    public class DoctorDAO : GenericDAO<Doctor>, IDoctorDAO
    {
        public DoctorDAO(ISession session) : base(session) { }

        public void DeleteDoctorByName(string doctorName)
        {
            Doctor doctor = GetDoctorByName(doctorName);

            // Here I had an exception: Deleted object would be re-saved by cascade (remove deleted object from associations)

            foreach (Patient p in doctor.PatientList)
            {
                // We need to remove this Doctor (reference) from every Patient it has
                p.DoctorList.Remove(doctor);

                // And also update that patient's Consultation-list without this doctor's consultations
                p.ConsultationList = p.ConsultationList.Except(doctor.ConsultationList).ToList();
            }

            // Nobody has reference to this doctor, we can emove
            Delete(doctor);
        }


        public IList<Patient> GetAllPatientsOfDoctor(string doctorName)
        {
            // Verbatim string (w/o escape) with interpolation (vars inside)
            // string query = $@"SELECT patient.* FROM patient JOIN doctor ON patient.doctor_id = doctor.id WHERE doctor.doctorname = '{doctorName}'";
            // return session.CreateSQLQuery(query).AddEntity("Patient", typeof(Patient)).List<Patient>();
            Doctor doctor = GetDoctorByName(doctorName);
            return doctor.PatientList;
        }

        public Doctor GetDoctorByName(string doctorName)
        {
            Doctor doctor = new Doctor();
            doctor.DoctorName = doctorName;
            ICriteria criteria = session.CreateCriteria(typeof(Doctor)).Add(Example.Create(doctor));
            return criteria.List<Doctor>()[0];
        }

        public IList<Consultation> GetAllConsultationsOfDoctor(Doctor doctor)
        {
            // Verbatim string (w/o escape) with interpolation (vars inside)
            // string query = $@"SELECT consultation.* FROM consultation JOIN doctor ON consultation.doctor_id = doctor.id WHERE doctor.doctorname = '{doctorName}'";
            // return session.CreateSQLQuery(query).AddEntity("Consultation", typeof(Consultation)).List<Consultation>();

            return doctor.ConsultationList;
        }
    }
}
