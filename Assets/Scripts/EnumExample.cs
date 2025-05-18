using UnityEngine;
public class EnumExample : MonoBehaviour
{
    public WorldLoadState currentWorldState;

    public enum WorldLoadState
    {
        NotLoaded,
        Loading,
        Loaded,
        FailedToLoad
    }

    void Start()
    {
        switch (currentWorldState)
        {
            case WorldLoadState.NotLoaded:
                Debug.Log("The world has not been loaded yet.");
                break;
            case WorldLoadState.Loading:
                Debug.Log("Loading world assets...");
                break;
            case WorldLoadState.Loaded:
                Debug.Log("World loaded successfully!");
                break;
            case WorldLoadState.FailedToLoad:
                Debug.Log("World failed to load.");
                break;
        }
    }
}
