using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameEndlessRunner
{
    public class obstacle : MonoBehaviour
{
    public float speed,Times;
    public GameObject effect;

    private void Update() 
    {
        Times += 0.1f;
        speed = Times;
        transform.Translate(Vector2.down * speed * Time.deltaTime);   
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player")){
            other.GetComponent<Player>().health--;
            other.GetComponent<Player>().camAnim.SetTrigger("shake");
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }    
    }
}
}
