using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEndlessRunner
{
    public class Background : MonoBehaviour
{
    public float speed;
    public float Yend;
    public float Ystart;

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (transform.position.y < Yend) {
            Vector2 pos = new Vector2(transform.position.x, Ystart);
            transform.position = pos;
        } 
    }
    
}
}
