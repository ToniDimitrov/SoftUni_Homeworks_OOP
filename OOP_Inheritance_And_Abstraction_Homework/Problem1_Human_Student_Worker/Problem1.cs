using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1_Human_Student_Worker
{
    internal class Problem1
    {
        private static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            try
            {
                students.Add(new Student("Angelina", "Jolie", "234gds"));
                students.Add(new Student("Sharo", "The dog", "5641fs"));
                students.Add(new Student("Godji", "Ivanov", "fs54dfe"));
                students.Add(new Student("Adriana", "Lima", "dfdsfa"));
                students.Add(new Student("Radka", "Piratka", "655467"));
                students.Add(new Student("Radka", "Kurshuma", "313244s"));
                students.Add(new Student("Freddie", "Mercury", "8d79fs"));
                students.Add(new Student("Nikol", "Stankulova", "f13266fd1"));
                students.Add(new Student("Princess", "Anastasia", "g8ss7g97"));
                students.Add(new Student("Volen", "Siderov", "NATFIZ12"));
            }
            catch (ArgumentNullException e)
            {
                Console.Error.WriteLine(e.Message);
                Console.WriteLine();
            }
            catch (ArgumentException e)
            {
                Console.Error.WriteLine(e.Message);
                Console.WriteLine();
            }
            students = new List<Student>(students.OrderBy(p => p.FacultyNumber));
            //students.ForEach(Console.WriteLine);
            //
            //
            List<Worker> workers = new List<Worker>();
            try
            {
                workers.Add(new Worker("Kyci", "Vapzarov", 450, 10));
                workers.Add(new Worker("Queen", "Elizabeth II", 99999, 24));
                workers.Add(new Worker("Boiko", "Borisov", 99999, 1));
                workers.Add(new Worker("Boiko", "Aleksandrov", 1234, 8));
                workers.Add(new Worker("Slavi", "Trifonov", 1456, 1));
                workers.Add(new Worker("Komissar", "Rex", 0, 12));
                workers.Add(new Worker("Al", "Bundy", 120, 10));
                workers.Add(new Worker("Dan", "Bilzerian", 9999, 1));
                workers.Add(new Worker("Ivo", "Andonov", 2000, 5));
                workers.Add(new Worker("Hermione", "Granger", 123, 8));
            }
            catch (ArgumentNullException e)
            {
                Console.Error.WriteLine(e.Message);
                Console.WriteLine();
            }
            catch (ArgumentException e)
            {
                Console.Error.WriteLine(e.Message);
                Console.WriteLine();
            }
            workers = new List<Worker>(workers.OrderBy(p => p.MoneyPerHour()));
            //workers.ForEach(Console.WriteLine);
            //
            //
            List<Human> mergedList = new List<Human>();
            mergedList.AddRange(workers);
            mergedList.AddRange(students);

            mergedList = new List<Human>(mergedList.OrderBy(p => p.FirstName).ThenBy(p =>p.LastName));
            mergedList.ForEach(Console.WriteLine);


        }
    }
}