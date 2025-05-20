using UnityEngine;
public class Weapon : MonoBehaviour
{
    public string Name;
    public int Damage;
    public virtual void Attack()
    {
        Debug.Log("The weapon is attacking!");
    }
}