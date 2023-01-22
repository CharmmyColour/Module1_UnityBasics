using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class GameOverMery : MonoBehaviour     
{
    public void Start()
    {
        ManagerMery.lives = 3;           
        ManagerMery.score = 0;
    }
    public void GameOver()
    {
        SceneManager.LoadScene("FlappyBirdMery");    
    }
}