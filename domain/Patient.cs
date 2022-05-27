using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4NHibernateIndividual.domain
{
    // Patient entity
    public class Patient : EntityBase
    {
        public virtual string PatientName { get; set; }
        public virtual int InsuranceId { get; set; }
        public virtual string Diagnosis { get; set; }

        private IList<Doctor> _doctorList = new List<Doctor>();

        public virtual IList<Doctor> DoctorList
        {
            get { return _doctorList; }
            set { _doctorList = value; }
        }

        // One -to-Many. One Patient can have many Consultations
        private IList<Consultation> _consultationList = new List<Consultation>();

        public virtual IList<Consultation> ConsultationList
        {
            get { return _consultationList; }
            set { _consultationList = value; }
        }

        // For displaying in combobox
        public override string ToString()
        {
            return $"{PatientName} {InsuranceId}";
        }
    }
}
