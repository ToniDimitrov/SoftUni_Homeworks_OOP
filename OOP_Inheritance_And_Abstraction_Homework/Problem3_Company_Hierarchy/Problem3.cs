using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3_Company_Hierarchy
{
    internal class Problem3
    {
        private static void Main(string[] args)
        {
            HashSet<Project> projects1 = new HashSet<Project>()
            {
                new Project("Visual Studio",new DateTime(2010,1,1),"Open","Visual Studio 2010 Ultimate"),
                new Project("Excel",new DateTime(2011,1,1),"Open","Microsoft Excel 2011"),
                new Project("Word",new DateTime(2001,1,1),"Closed","Microsoft Word")
            };
            HashSet<Project> projects2 = new HashSet<Project>()
            {
                new Project("GTA 4",new DateTime(2010,10,1),"Open","Grand Theft Auto IV"),
                new Project("Call of Duty",new DateTime(2011,2,1),"Open","Call of duty modern warfare 2"),
                new Project("Snake",new DateTime(2001,5,1),"Closed","Snake game"),
                new Project("GTA5",new DateTime(2013,5,1),"Open","Grand theft auto V")
            };
            HashSet<Project> projects3 = new HashSet<Project>()
            {
                new Project("Homework 4",new DateTime(2010,10,1),"Open","cccc"),
                new Project("Excercise",new DateTime(2011,2,1),"Open","bbb"),
                new Project("Lab",new DateTime(2001,5,1),"Closed","aaa"),
                new Project("Exam",new DateTime(2013,5,1),"Open","djfh")
            };
   
            HashSet<Sale> sales1 = new HashSet<Sale>()
            {
                new Sale("sale01",120.40m,new DateTime(2001,01,1)),
                new Sale("sale02",220.40m,new DateTime(2002,02,2)),
                new Sale("sale03",320.40m,new DateTime(2003,03,3))
            };
            HashSet<Sale> sales2 = new HashSet<Sale>()
            {
                new Sale("sale04",420.40m,new DateTime(2004,04,4)),
                new Sale("sale05",520.40m,new DateTime(2005,05,5)),
                new Sale("sale06",620.40m,new DateTime(2006,06,6))
            };
            HashSet<Sale> sales3 = new HashSet<Sale>()
            {
                new Sale("sale07",720.40m,new DateTime(2007,04,4)),
                new Sale("sale08",820.40m,new DateTime(2008,05,5))
            };

            HashSet<RegularEmployee> regularEmployees1= new HashSet<RegularEmployee>()
            {
                new Developer("123","Georgi","Georgiev",1200.40m,"Production",projects1),
                new SalesEmployee("124","Petar","Petrov",800.00m,"Sales",sales2)
            };
            HashSet<RegularEmployee> regularEmployees2 = new HashSet<RegularEmployee>()
            {
                new Developer("125","Bat","Georgi",1000.40m,"Accounting",projects2),
                new SalesEmployee("126","Bat","Pesho",900.00m,"Marketing",sales1)
            };

            HashSet<Employee> employees = new HashSet<Employee>()
            {
                new Manager("127","Sharo","Sharenov",2500.00m,"Production",regularEmployees1),
                new Manager("128","Ivan","Ivanov",2600.00m,"Accounting",regularEmployees2),
                new SalesEmployee("129","Ne znam","Veche",1233.03m,"Sales",sales3),
                new Developer("129","She","Umra",3333.33m,"Production",projects3)
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString() + "\n");
            }
        }
    }
}