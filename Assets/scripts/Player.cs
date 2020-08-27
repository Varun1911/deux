using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 600f;
    float movement = 0f;
    [SerializeField] Vector3 centre = new Vector3(0, -2.75f, 0);

    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            touchPos.z = 0f;
            if (touch.phase == TouchPhase.Stationary )
            {
                if (touchPos.x > 0)
                    movement = 1f;
                else if (touchPos.x < 0)
                    movement = -1f;
            }
            if (touch.phase == TouchPhase.Ended)
            {
                movement = 0f;
            }
            
        }
    }

    private void FixedUpdate()
    {
        transform.RotateAround(centre, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

}
