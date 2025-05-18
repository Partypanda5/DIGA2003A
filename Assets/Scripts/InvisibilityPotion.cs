using UnityEngine;

public class InvisibilityPotion : Potion
{
    public void BecomeInvisible()
    {
        Debug.Log("You fade from sight");
    }

    void Start()
    {
        Drink();
        BecomeInvisible();
    }
}
