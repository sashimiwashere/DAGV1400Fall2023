using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{ 
    public ScoreManager scoreManager; // Store reference to score manager
    public int scoreToGive;

    [SerializeField] private AudioSource destroySoundEffect;
    
    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Find scoremanager gameobject and reference script componet
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if(other.gameObject.CompareTag("Weapon"))
        {
            scoreManager.IncreaseScore(scoreToGive); // Increase the score
            Destroy(gameObject);
            destroySoundEffect.Play();
            Destroy(other.gameObject);
        }
    }
}
