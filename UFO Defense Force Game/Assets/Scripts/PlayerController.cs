using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float xRange = 45;

    public Transform blaster;

    public GameObject laser;

    public GameManager gameManager;
    
    [SerializeField] private AudioSource fireSoundEffect;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");   //Set HorizontalInput for keyboard

        transform.Translate(Vector3.right * hInput * Time.deltaTime * speed);   // Move player left and right

        if(transform.position.x < -xRange)  // Left wall inbounds
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)   // Right wall inbounds
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if(Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false) // press space to fire laser
        {
            fireSoundEffect.Play();
            Instantiate(laser, blaster.transform.position, laser.transform.rotation);   // Create laser from blaster position to object rotation
        }
        
    }
   
}
