using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour
{
    [SerializeField] LevelLoader levelLoader;
    [SerializeField] float baseScore = 30f;
    [SerializeField] Text scoreText;
    [SerializeField] spawner spawnerRef;
    float score = 0f;
    
    public static GameManager instance;

    private void Awake()
    {
        instance = this;
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
        SetScore();
        SetHighScore();
        levelLoader.LoadNextLevel();
    }
}
