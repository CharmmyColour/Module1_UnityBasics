using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerMery : MonoBehaviour
{ 
    public static int lives = 3;
    public static int score = 0;

    public Text scoreText;
    public Text livesText;

    public void Update()
    {
        scoreText.text = score.ToString();
        livesText.text = lives.ToString();
    }
}
