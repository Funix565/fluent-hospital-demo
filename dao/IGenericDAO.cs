using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4NHibernateIndividual.dao
{
    // Interface with CRUD operations
    public interface IGenericDAO<T>
    {
        void SaveOrUpdate(T item);
        T GetById(long id);
        List<T> GetAll();
        void Delete(T item);
    }
}
