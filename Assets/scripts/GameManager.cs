using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] float baseScore = 30f;
    [SerializeField] Text scoreText;
    [SerializeField] Text highScoreText;
    [SerializeField] spawner spawnerRef;
    float score = 0f;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString("0");
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
            highScoreText.text = score.ToString("0");
        }

    }

    public void GameEnd()
    {
        SetHighScore();
        SceneManager.LoadScene(0);
    }
}
