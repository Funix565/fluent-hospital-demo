using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4NHibernateIndividual.domain
{
    // Consultation entity. Has information about Doctor, Patient, Date and Room
    public class Consultation : EntityBase
    {
        public virtual Doctor GetDoctor { get; set; }
        public virtual Patient GetPatient { get; set; }
        public virtual DateTime GetConsultationTime { get; set; }
        public virtual int RoomNumber { get; set; }
    }
}
