using System.Collections.Generic;
using UnityEngine;
public class Action : MonoBehaviour
{
    void Start()
    {
       //create an instance of sword and bow on this game object
        Sword sword = gameObject.AddComponent<Sword>();
        Bow bow = gameObject.AddComponent<Bow>();

       //create a list to collect all the weapons
        List<Weapon> weapons = new List<Weapon> { sword, bow };

        // Call Attack() on each weapon 
        foreach (Weapon weapon in weapons)
        {
            weapon.Attack();
        }
    }
}
