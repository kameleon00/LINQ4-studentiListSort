using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Napisati konzolnu aplikaciju za formiranje kolekcije studenata. Definisati klasu
              Student koja ima atribute ime, godiste, brIndeksa i prosecnaOcena. Primenom LINQ odredbi
             sortirati studente prema imenu, izdvojiti studente mlaĎe od 1994. godište i izdvojiti studente sa
            prosekom iznad 8.5 sortirane u rastućem redosledu. */

            List<Student> stud = new List<Student>()
            {
                new Student("Mika", 1997, "210/2016", 9),
                new Student("Pera", 1996, "132/2014", 7.8),
                new Student("Marko", 1995, "98/2013", 6.12),
                 new Student("Nikola", 1998, "106/2016", 8.80),
                 new Student("Sara", 1995, "301/2013", 9.7),
                 new Student("Sanja", 1994, "489/2013",7.00),
                 new Student("Milos", 1998, "68/2016", 10),
                 new Student("Nemanja", 1994, "155/2013", 8.6),
                 new Student("Zika", 1998, "55/2016", 6.70),
                new Student("Uros", 1998, "158/2016", 9.50),
            };

            var rezultatUpita = from s in stud
                                orderby s.Ime
                                select s;
            /* II nacin preko lambda izraza:
            var rezultatiUpita1 = studenti.OrderBy(s => s.Ime); */

            Console.WriteLine("Sortirani studenti: ");
            foreach (Student student in rezultatUpita)
                Console.WriteLine(student);
            Console.WriteLine("================================================");

            Console.WriteLine("Studenti mladji od 1994. ");
            var mladjiStudenti = from s in stud
                                 where s.Godiste > 1994
                                 orderby s.Ime
                                 select s;
            /* II nacin preko lambda izraza:
            var mladjiStudenti = studenti.OrderBy(s => s.Ime).Where(s => s.Godiste > 1994);*/
            Console.WriteLine("Studenti rodjeni nakon 1994 godine: ");
            foreach (Student student in mladjiStudenti)
                Console.WriteLine(student);
            Console.WriteLine("================================================");

            var studentiSaProsekom = from s in stud
                                     where s.ProsecnaOcena > 8.5
                                     orderby s.ProsecnaOcena
                                     select s;
            //var studentiSaProsekom = stud.OrderBy(s => s.ProsecnaOcena).Where(s => s.ProsecnaOcena > 8.5);
            Console.WriteLine("Studenti sa prosekom vecim pd 8.5: ");
            foreach (Student student in mladjiStudenti)
                Console.WriteLine(student);
            Console.WriteLine("================================================");

            Console.WriteLine("Broj studenata sa prosekom iznad 8.5 je: " + studentiSaProsekom.Count());

            Console.ReadLine();
        }
    }
}
