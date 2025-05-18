using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage;
    public int health;

    public void TakeDamage(int amount) 
    {
        health -= amount;
    }
}
