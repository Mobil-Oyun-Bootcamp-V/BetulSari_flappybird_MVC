using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BirdController 
{
    private Rigidbody2D rb2D;
    public BirdModel model;
    public BirdView view;

    public BirdController(BirdModel model, BirdView view)
    {
        model = new BirdModel();
        this.view = view;
    }
    
    public void update()
    { 
        view.Move(model.velocity);
        view.RestartGame();
    }

    public void start()
    { 
        rb2D = view.GetComponent<Rigidbody2D>();
    }
    
    
    private void Start() 
    {
        Time.timeScale = 1;
    }
    

    public void Moving(float velocity)
    {
        rb2D.velocity = Vector2.up * velocity;
    }
    
    
    public void UpdateScore(int score, Text ScoreText)
    {
        score++;
        ScoreText.text = score.ToString();

    }
    
    
}