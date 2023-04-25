using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEndlessRunner
{
    public class Destroy : MonoBehaviour
{
    public float lifetime;

    private void Start()
    {
        Destroy(gameObject, lifetime);
    }
    
}
}
