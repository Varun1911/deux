using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] float width = 5.625f;

    void Start()
    {
        float orthoSize = width * Screen.height / Screen.width * 0.5f;

        Camera.main.orthographicSize = orthoSize; 
    }

}
