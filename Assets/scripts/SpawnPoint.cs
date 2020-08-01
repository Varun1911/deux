using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] GameObject obstacle;

    void Start()
    {
        Instantiate(obstacle, transform.position, Quaternion.identity);
        Debug.Log(obstacle);
    }
}
