using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new instance of the store class and pass in two argumants
            Company store1 = new Company("WalMeg", DateTime.Now);
            Console.WriteLine($"{store1.Name} {store1.CreatedOn}");


            // create a new instance of the employee class and pass in 3 args to set employee list, this will set the variables or properties in the Employee class and it will then be used as a Type
            // Employee num1 = new Employee("Meggy", "teacher", DateTime.Now);
            // Employee num2 = new Employee("Steve", "Boss", DateTime.Now);
            // Employee num3 = new Employee("Hannah", "BomDotCom", DateTime.Now);


            // a "dryer" --Matt B. instruction, way of adding new Employee to Company by creating a new list 
            // List<Employee> newEmployees = new List<Employee>{ num1, num2, num3 };
            List<Employee> newEmployees = new List<Employee>{ 
                new Employee("Meggy", "teacher", DateTime.Now),
                new Employee("Steve", "Boss", DateTime.Now),
                new Employee("Hannah", "BomDotCom", DateTime.Now)
            };

            // then foreach over the list , call the method and pass in the argument
            foreach(Employee person in newEmployees){
                store1.AddEmployee(person);
            }
            
            // now add the new Employees to the Company List that uses the Employee type. The Company Class will call the Employee classto get the already set lists from the Contructor function
            // store1.AddEmployee(num1);
            // store1.AddEmployee(num2);
            // store1.AddEmployee(num3);

            // Call this Method in Company Class to log out each List item that has been set 
            store1.ListEmployees();

            // Call Method in Company Class that will remove the List item and pass in which list to remove
            store1.RemoveEmployee("Hannah");
        }
    }
}

public class Company
{
    // Some readonly properties
    // The variable type for the fields must be set, only apply get; when it can only be read not set
    public string Name { get;}
    public DateTime CreatedOn { get;}

    // Create a property for holding a list of current employees
    // this works too! public List<Employee> Employees = new List<Employee>();

    // this creates a public list with the type of Employee which was made in the Employee Class, create a new instance of the List with Employee type
    public List<Employee> Employees = new List<Employee>();

    public Company(string coName, DateTime started){
        Name = coName;
        CreatedOn = started;
    }
    // Create a method that allows external code to add an employee
    //this method if called in the Main Method and passes in an argument of Employee type, the type must be the declared and the arg name can be anything
    public void AddEmployee(Employee taco) {
        Employees.Add(taco);

    }
    // public void AddEmployee(Employee taco, int num) {
    //     Employees.Add(taco);
    // }
    
    // Create a method that allows external code to remove an employee

    //Look into SingleOrDefault to delete
    public void RemoveEmployee(string taco) {
        Employees.Remove(taco);
    }
    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created
        The constructor will set the value of the public properties
    */


    public void ListEmployees() {
        foreach (Employee item in Employees)
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

    public Employee(string name){
        Console.WriteLine("Hey " + name);
    }
    // public Employee(string position, string poop){
    //     Console.WriteLine("Hey " + name);
    // }

}