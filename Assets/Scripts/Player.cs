using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace GameEndlessRunner
{
    public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Xincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 3;

    public GameObject moveEffect;
    public Animator camAnim, playerAnim;
    public TMP_Text healthDisplay;
    public GameObject spawner;
    public GameObject restartDisplay;
    private SpriteRenderer playerRenderer;
    [SerializeField] private AudioSource jumpsoundEffect,hitsoundEffect;

    private void Start() {
        playerRenderer = GetComponent<SpriteRenderer>();
        targetPos = new Vector2(-3, -3);
    }

    private void Update() {

        if(health <= 0)
        {
            spawner.SetActive(false);
            restartDisplay.SetActive(true);
            Destroy(gameObject);
        }else if(health >0){
            spawner.SetActive(true);
        }
        healthDisplay.text = health.ToString();

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxHeight) {
            jumpsoundEffect.Play();
            camAnim.SetTrigger("shake");
            Instantiate(moveEffect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x + Xincrement, transform.position.y);
            playerRenderer.flipY = false;
        }else if(Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minHeight) {
             jumpsoundEffect.Play();
            camAnim.SetTrigger("shake");
            Instantiate(moveEffect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x - Xincrement, transform.position.y);
            playerRenderer.flipY = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Obstacle"))
        {
            hitsoundEffect.Play();
        }    
    }
}
}
