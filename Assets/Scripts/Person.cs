using UnityEngine;

// Base class
public class Person: MonoBehaviour
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
