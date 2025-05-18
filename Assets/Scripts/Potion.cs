using UnityEngine;

public class Potion : MonoBehaviour
{
    public string potionName;
    public int potency;
    public float volume;

    public void Drink()
    {
        Debug.Log("You drank a " + potionName + ". Potency: " + potency + ", Volume: " + volume);
    }
}
