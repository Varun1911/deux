using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] LevelLoader levelLoader;

    public void PlayGame()
    {
        levelLoader.LoadNextLevel();
        Vibration.Vibrate(50);
    }

    public void QuitGame()
    {
        Vibration.Vibrate(50);
        Application.Quit();
    }
}
