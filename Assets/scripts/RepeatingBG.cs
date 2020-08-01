using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour
{
    [SerializeField] float bgSpeed = 4f;
    [SerializeField] float endX = -10f;
    [SerializeField] float startX = 10f;


    void Update()
    {
        transform.Translate(Vector2.down * bgSpeed * Time.deltaTime);

        if (transform.position.y <= endX)
        {
            Vector2 pos = new Vector2(transform.position.x, startX);
            transform.position = pos;
        }
    }
}
