using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4NHibernateIndividual.domain
{
    // Doctor entity
    public class Doctor : EntityBase
    {
        private IList<Patient> _patientList = new List<Patient>();
        public virtual string DoctorName { get; set; }
        public virtual string JobTitle { get; set; }

        // One-to-Many. One Doctor can have many Consultations
        private IList<Consultation> _consultationList = new List<Consultation>();

        public virtual IList<Patient> PatientList
        {
            get { return _patientList; }
            set { _patientList = value; }
        }

        public virtual IList<Consultation> ConsultationList
        {
            get { return _consultationList; }
            set { _consultationList = value; }
        }
    }
}
