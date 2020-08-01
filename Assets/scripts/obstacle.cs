using UnityEngine;
using UnityEngine.SceneManagement;

public class obstacle : MonoBehaviour
{
    [SerializeField] float obstacleSpeed = 40f;
    [SerializeField] float targetY;
    Vector2 target;

    private void Start()
    {
        target = new Vector2(transform.position.x, targetY);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, obstacleSpeed * Time.deltaTime);
        
        if(transform.position.y < -5.8f)
        {
            Destroy(gameObject);
        }
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
