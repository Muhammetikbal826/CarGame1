using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
 
 
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    private int puan = 10;

    public static int score = 0;
    public static int highScore = 0;

    private void Awake()
    {
        instance = this;
    }


    void Start()
    {
        scoreText.text = "Points  " + score.ToString();

    }

    public void AddPoint()
    {
        score += puan;
        scoreText.text = "Points  " + score.ToString();

    }
}

