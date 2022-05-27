using FluentNHibernate.Mapping;
using Lab4NHibernateIndividual.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4NHibernateIndividual.mapping
{
    public class ConsultationMap : ClassMap<Consultation>
    {
        public ConsultationMap()
        {
            Table("Consultation");

            Id(x => x.Id).GeneratedBy.Native();

            Map(x => x.GetConsultationTime, "consultation_time");
            Map(x => x.RoomNumber);

            // The Consultation table will have these two columns.
            // Reference doctor and patient tables by foreign keys.
            References(x => x.GetDoctor, "doctor_id");
            References(x => x.GetPatient, "patient_id");
        }
    }
}
