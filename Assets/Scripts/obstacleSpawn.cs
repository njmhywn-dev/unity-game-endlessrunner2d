using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEndlessRunner
{
    public class obstacleSpawn : MonoBehaviour
{
    public GameObject obstacle;

    private void Start()
    {
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }
}
}
