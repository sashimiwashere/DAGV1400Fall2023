using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    private GameObject gameOverText;

    [SerializeField] private AudioSource gameOverSoundEffect;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
    }

    void Update()
    {
        if(isGameOver)
        {
            EndGame();
            
        }
        else
        {
            gameOverText.gameObject.SetActive(false);
        }
    }
    public void EndGame()
    {
        gameOverSoundEffect.Play();
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
