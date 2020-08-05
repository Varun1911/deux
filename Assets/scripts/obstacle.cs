using UnityEngine;
using UnityEngine.SceneManagement;

public class obstacle : MonoBehaviour
{
    [SerializeField] protected float obstacleSpeed = 40f;
    [SerializeField] protected float targetY;
    protected Vector2 target;
  

    private void Start()
    {
        target = new Vector2(transform.position.x, targetY);
    }

    public virtual void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, obstacleSpeed * Time.deltaTime);
        
        if(transform.position.y < -5.8f)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instance.GameEnd();
    }

   
}
