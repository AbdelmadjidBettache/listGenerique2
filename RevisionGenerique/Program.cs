using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionGenerique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalleService salleService = new SalleService();
            
            salleService.create(new Salle("S001", "A"));
            salleService.create(new Salle("S002", "B"));
            salleService.create(new Salle("S003", "C"));
            salleService.create(new Salle("S004", "D"));
            salleService.create(new Salle("S005", "E"));


            Console.WriteLine("Affichage de la liste des salles:");
            foreach (Salle salle in salleService.findAll())            
            Console.WriteLine("\t" + salle);

            Console.WriteLine("Supprimer une salle: ");
            salleService.delete(salleService.findById(1));
            foreach (Salle salle in salleService.findAll())
                Console.WriteLine("\t" + salle);

            Console.WriteLine("Modifier les information de la salle avec id=2");
            Salle s = salleService.findById(2);

            Console.WriteLine("Salle a modifier: " +s);

            Console.WriteLine("Donner nouvelle code : ");
            s.Code=Console.ReadLine();
            Console.WriteLine("Donner le libelle: ");
            s.Libelle=Console.ReadLine();
            salleService.update(s);

            Console.WriteLine("Salle est modifier: " + s);

            Console.WriteLine("Affichage de la liste des sallesapres modification:");
            foreach (Salle salle in salleService.findAll())
                Console.WriteLine("\t" + salle);

            Console.ReadKey();
        }
    }
}
