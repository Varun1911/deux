using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] GameObject obstacle;

    float timeBtwSpawn;
    [SerializeField] float startTimeBtwSpawn;
    [SerializeField] float decreaseTime = 0.05f;
    [SerializeField] float minTime = 0.65f;

    private void Start()
    {
        timeBtwSpawn = startTimeBtwSpawn;
    }


    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            Vector3 position = new Vector3(Random.Range(-1.16f, 1.16f), transform.position.y, transform.position.z);
            Instantiate(obstacle, position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if(startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
