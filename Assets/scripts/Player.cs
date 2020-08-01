using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed = 600f;
    float movement = 0f;
    [SerializeField] Vector3 centre = new Vector3(0, -2.75f, 0);

    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        transform.RotateAround(centre, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }
}
