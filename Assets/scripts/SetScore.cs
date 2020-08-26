using UnityEngine.UI;
using UnityEngine;

public class SetScore : MonoBehaviour
{
    [SerializeField] Text highScoreText;
    [SerializeField] Text scoreText;

    private void Awake()
    {
        highScoreText.text = "HI : " + PlayerPrefs.GetInt("HighScore", 0).ToString("0");
        scoreText.text = PlayerPrefs.GetInt("Score", 0).ToString("0");
    }
}
