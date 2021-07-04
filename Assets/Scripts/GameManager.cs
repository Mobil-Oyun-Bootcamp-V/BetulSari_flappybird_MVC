using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    BirdModel model;
    public BirdView view;
    BirdController controller;
    public Text ScoreText;
    public int score;
    public GameObject DeathScreen;

    private void Awake()
    {
        model = new BirdModel();
        controller = new BirdController(model,view);
        
        controller.start();
    }
    

    void Start()
    {
        
        score = 0;
        ScoreText.text = score.ToString();
    }

    void Update()
    {
        controller.update();
    }
    

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
    
    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "DeathArea")
        {
            bool isDead = true;
            Time.timeScale = 0;
             
            DeathScreen.SetActive(true);
        }
    }

}
