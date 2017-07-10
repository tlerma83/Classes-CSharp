using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Company store1 = new Company("WalMeg", DateTime.Now);
            Console.WriteLine($"{store1.Name} {store1.CreatedOn}");

            Employee number1 = new Employee("Meggy", "teacher", DateTime.Now);
            // number1.Name = "Meggy";
            // number1.JobTitle = "teacher";
            // number1.StartDate = DateTime.Now;
            Employee num2 = new Employee("Steve", "scary", DateTime.Now);
            store1.AddEmployee(num2);
            store1.AddEmployee(number1);

            store1.ListEmployees();

            // Console.WriteLine($"What is {number1}");
            // store1.ListEmployees(Employee number1);

            // store1.RemoveEmployee(number1);
            // Console.WriteLine(store1.Employees.Count);
            // store1.Name = "Meg's";
            // store1.CreatedOn = DateTime.Now;

        }
    }
}

public class Company
{
    /*
        Some readonly properties
    */
    public string Name { get;}
    public DateTime CreatedOn { get;}

    // Create a property for holding a list of current employees
    // this works too!
    // public List<Employee> Employees = new List<Employee>();
    public List<Employee> Employees = new List<Employee>();

    // Create a method that allows external code to add an employee
    //create method to set by passing in type and var
    public void AddEmployee(Employee taco) {
        Employees.Add(taco);
    }
    // Create a method that allows external code to remove an employee
    public void RemoveEmployee(Employee taco) {
        Employees.Remove(taco);
    }
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created
        The constructor will set the value of the public properties
    */

    public Company(string coName, DateTime started){
        Name = coName;
        CreatedOn = started;
    }

    public void ListEmployees() {
        foreach (Employee item in this.Employees)
        {
            Console.WriteLine($"{item.Name} {item.JobTitle} {item.StartDate}");
        }
    }
}

public class Employee 
{
    public string Name {get; set;}
    public string JobTitle {get; set;}

    public DateTime StartDate {get; set; }

    public Employee(string name, string position, DateTime dateMan) {
        Name = name;
        JobTitle = position;
        StartDate = dateMan;
    }
}