using FluentNHibernate.Mapping;
using Lab4NHibernateIndividual.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4NHibernateIndividual.mapping
{
    public class PatientMap : ClassMap<Patient>
    {
        public PatientMap()
        {
            Table("patient");

            Id(x => x.Id).GeneratedBy.Native();
            Map(x => x.PatientName);
            Map(x => x.InsuranceId);
            Map(x => x.Diagnosis);

            // Consultation mapping
            HasMany(x => x.ConsultationList)
                .Inverse()
                .Cascade.All()
                .Table("consultation");
        }
    }
}
