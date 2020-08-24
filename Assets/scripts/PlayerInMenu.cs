using UnityEngine;

public class PlayerInMenu : MonoBehaviour
{
    [SerializeField] Vector3 centre = new Vector3(0, 0, 0);
    [SerializeField] float moveSpeed = 600f;

    private void FixedUpdate()
    {
        transform.RotateAround(centre, Vector3.forward,  Time.fixedDeltaTime * -moveSpeed);
    }
}
