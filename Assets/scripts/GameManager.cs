using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //references
    [SerializeField] GameObject _spawner;
    [SerializeField] GameObject[] players;
    [SerializeField] Text scoreText;
    [SerializeField] spawner spawnerRef;
    [SerializeField] LevelLoader levelLoader;


    [SerializeField] float baseScore = 30f;
    float score = 0f;
    
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
       // Application.targetFrameRate = 60;
    }


    void Update()
    {
        score += (baseScore / spawnerRef.startTimeBtwSpawn * Time.deltaTime);
        scoreText.text = score.ToString("0");
    }

    public void SetHighScore()
    {
        if (score > PlayerPrefs.GetInt("HighScore" , 0))
        {
            PlayerPrefs.SetInt("HighScore", (int)score);
        }

    }

    public void SetScore()
    {
        PlayerPrefs.SetInt("Score", (int)score);
    }

    public void GameEnd()
    {
        foreach (GameObject player in players)
        {
            player.GetComponent<Player>().enabled = false;
        }
       _spawner.GetComponent<spawner>().enabled = false;

        SetScore();
        SetHighScore();
        levelLoader.LoadNextLevel();
        Vibration.Vibrate(500);
    }
}
