using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] LevelLoader levelLoader;

    public void PlayGame()
    {
        levelLoader.LoadNextLevel();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
