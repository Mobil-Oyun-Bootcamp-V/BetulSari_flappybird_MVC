using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdView : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private BirdController controller;
    private GameManager _gameManager;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    public void Move(float velocity)
     {
         if (Input.GetMouseButtonDown(0))
         {
             controller.Moving(velocity);
         }
     }
    
     private void OnTriggerEnter2D(Collider2D collision) {
         if(collision.gameObject.name == "ScoreArea")
         {
             controller.UpdateScore(_gameManager.score, _gameManager.ScoreText);
         }
     }
     
     
     public void RestartGame()
     {
         SceneManager.LoadScene(0);
     }
     
}
