using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class PointManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    public static event Action OnPlayerWin;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "SCORE" + score;
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "SCORE" + score;
        if(score > 1000)
        {
            Debug.Log("you win");
            OnPlayerWin?.Invoke();

        }
    }
   
}
