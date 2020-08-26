using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] LevelLoader levelLoader;

    public void ReplayGame()
    {
        levelLoader.LoadPrevLevel();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
