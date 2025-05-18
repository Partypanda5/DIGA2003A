using UnityEngine;

public class HealthPotion : Potion
{
    public void RestoreHealth()
    {
        Debug.Log("You feel stronger!");
    }

    void Start()
    {
        Drink();
        RestoreHealth();
    }
}
