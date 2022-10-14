using OCPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of applicants
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Archie", LastName = "Fan" },
                new ManagerModel { FirstName = "GuiZhen", LastName = "Liu" },
                new ExecutiveModel { FirstName = "YuKiu", LastName = "Fan" }
            };

            // Assisted the account for each applicants so that they become employee
            List<EmployeeModel> employees = new List<EmployeeModel>();
            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            // list out all employees
            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager: { emp.IsManager } IsExecutive: { emp.IsExecutive }");
            }

            Console.ReadLine();
        }
    }
}
