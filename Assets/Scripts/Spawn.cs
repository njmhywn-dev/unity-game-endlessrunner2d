using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEndlessRunner
{
    public class Spawn : MonoBehaviour
{
    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float timeDecrease;
    public float minTime;
    public GameObject[] obstacleTemplate;

  private void Start()
    {
        timeBtwSpawn = startTimeBtwSpawn;
    }

    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, obstacleTemplate.Length);
            Instantiate(obstacleTemplate[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > minTime) {
                startTimeBtwSpawn -= timeDecrease;
            }
        }
        else {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
}
