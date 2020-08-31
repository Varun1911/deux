using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] LevelLoader levelLoader;

    public void ReplayGame()
    {
        levelLoader.LoadPrevLevel();
        Vibration.Vibrate(50);
    }

    public void QuitGame()
    {
        Vibration.Vibrate(50);
        Application.Quit();
    }
}
