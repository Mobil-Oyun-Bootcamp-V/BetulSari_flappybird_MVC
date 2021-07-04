using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//view ve model arasında iletişim olmayacak
//controller ile hem view hemde model iletişim halinde olacak.
public class BirdModel
{

    public GameObject Pipes;
    public float height;
    public float time;
    
    
    
    
    public bool isDead;
    
    public float velocity = 1f;

    public GameManager managerGame;

}
