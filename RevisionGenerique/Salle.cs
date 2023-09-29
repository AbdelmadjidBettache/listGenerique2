using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionGenerique
{
    internal class Salle
    {
        private int id;
        private string code;
        private string libelle;

        private static int ctr;

        public int Id { get => id;}
        public string Code { get => code; set => code = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        public Salle(string code, string libelle)
        {
            this.id = ++ctr;
            this.Code = code;
            this.Libelle = libelle;
        }

        public override string ToString()
        {
            return "ID: "+id+" Code: "+code+" Libelle: "+libelle;
        }
    }
}
