using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
 
public class Score : MonoBehaviour
{
    public Text scoreText;
    public int maxScore = 6;
    public AudioSource CollisionSound;
    public AudioSource EndSound;
 
    int score;
 
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
        // CollisionSound = GetComponent<AudioSource>();
        // EndSound = GetComponent<AudioSource>();
       
    }
    
    //we will call this method from our target script
    // whenever the player collides or shoots a target a point will be added
    public void AddPoint()
    {
             score++;
            CollisionSound.Play();
 
        if (score != maxScore)
            scoreText.text = "Score: " + score;
        else{
            EndSound.Play();
            scoreText.text = "You won!";
        }
        }
    
}