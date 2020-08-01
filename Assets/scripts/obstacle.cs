using UnityEngine;
using UnityEngine.SceneManagement;

public class obstacle : MonoBehaviour
{
    [SerializeField] float obstacleSpeed = 40f;

    private void Update()
    {
        transform.Translate(Vector2.down * obstacleSpeed * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameOver();
    }

    private void GameOver()
    {
        SceneManager.LoadScene(0);
    }
}
