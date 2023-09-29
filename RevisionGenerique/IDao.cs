using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionGenerique
{
    internal interface IDao<T>
    {
        void create(T o);
        bool delete(T o);
        bool update(T o);
        T findById(int id);
        List<T> findAll();

    }
}
