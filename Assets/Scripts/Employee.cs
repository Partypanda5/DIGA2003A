using UnityEngine;

// Derived class
public class Employee : Person
{
    public int EmployeeID;

    public Employee(string name, int age, int employeeID) : base(name, age)
    {
        EmployeeID = employeeID;
    }
}
