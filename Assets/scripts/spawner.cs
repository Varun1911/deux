using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] GameObject[] obstacles;

    float timeBtwSpawn = 1f;
    [SerializeField] float startTimeBtwSpawn;
    [SerializeField] float decreaseTime = 0.05f;
    [SerializeField] float minTime = 0.65f;
    [SerializeField] float clampXPos = 1f;

   

    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, obstacles.Length);
            Vector3 position = new Vector3(Random.Range(-clampXPos, clampXPos), transform.position.y, transform.position.z);
            Vector3 rotation = new Vector3(obstacles[rand].transform.rotation.x, obstacles[rand].transform.rotation.y, Random.Range(0, 180));
            Instantiate(obstacles[rand], position, Quaternion.Euler(rotation));
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
