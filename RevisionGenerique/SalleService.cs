using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionGenerique
{
    internal class SalleService : IDao<Salle>
    {
        private List<Salle> salles;

        public SalleService()
        {
            salles = new List<Salle>();
        }

        public void create(Salle o)
        {
           salles.Add(o);
        }

        public bool delete(Salle o)
        {
            return salles.Remove(o);
        }

        public List<Salle> findAll()
        {
            return salles;
        }

        public Salle findById(int id)
        {
            foreach (Salle s in salles)
            {
                if(s.Id == id) 
                    return s;
            }
            return null;
        }

        public bool update(Salle o)
        {
            foreach (Salle item in salles)
            {
                if (item.Id == o.Id)
                {
                    item.Code = o.Code;
                    item.Libelle = o.Libelle;
                    return true;
                }
            }return false;
        }
    }
}
