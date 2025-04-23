using UnityEngine;
using TMPro;           // For TextMeshProUGUI framework so that we can manipualte the text
using UnityEngine.UI;  // For UI stuff, especially the slider

public class UI : MonoBehaviour
{
    public TextMeshProUGUI messageText; // Reference to Text UI in the scene
    public Slider valueSlider;          // Reference to Slider in the scene

    // Called when the display text button is pressed
    public void DisplayMessage()
    {
        messageText.text = "Button Pressed! Welcome to the game!";
    }

    // Called when the plus button is pressed
    public void IncreaseSlider()
    {
        valueSlider.value += 1f;
    }

    // Called when the minus button is pressed
    public void DecreaseSlider()
    {
        valueSlider.value -= 1f;
    }
}
