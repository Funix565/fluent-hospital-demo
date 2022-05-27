using FluentNHibernate.Mapping;
using Lab4NHibernateIndividual.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4NHibernateIndividual.mapping
{
    public class DoctorMap : ClassMap<Doctor>
    {
        public DoctorMap()
        {
            Table("doctor");

            Id(x => x.Id).GeneratedBy.Native();
            Map(x => x.DoctorName);
            Map(x => x.JobTitle);

            // Consultation mapping
            HasMany(x => x.ConsultationList)
                .Inverse() // usually we have Inverse() for collection
                .Cascade.All()
                .Table("consultation");
        }
    }
}
