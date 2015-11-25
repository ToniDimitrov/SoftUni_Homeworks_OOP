using System;
namespace Problem1_Persons
{
    class Persons_Main
    {
        static void Main(string[] args)
        {
            Person gosho = new Person("Gosho",19,"zadushaam_sa@bat.georgi");
            Person pesho = new Person("Pesho",20);

            Console.WriteLine(gosho);
            Console.WriteLine(pesho);

            string name = Console.ReadLine();
            String email = Console.ReadLine();
            int age = Int32.Parse(Console.ReadLine());
            try
            {
                Person chovechec = new Person(name, age, email);
                Console.WriteLine(chovechec);
            }
            catch (Exception exception)
            {
                Console.Error.WriteLine(exception.Message);
            }
      
        }
    }
}
