using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace GameEndlessRunner
{
    public class Score : MonoBehaviour 
    {

    public int score;
    public TMP_Text scoreDisplay;
    public TMP_Text scoreText;

    public GameEndlessRunner.Player player;

    private void Update()
    {
        scoreDisplay.text = score.ToString();
    }

    private void FixedUpdate() 
    {
        scoreText.text = score.ToString();

        if(player.health <= 0)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }else{
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        } 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        score++;
        Destroy(other.gameObject);
    }

    }
}
