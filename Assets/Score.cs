using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
 
public class Score : MonoBehaviour
{
    public static Score instance;

    public TextMeshProUGUI scoreText;
    private int para = 5;

    public static int score = 0;
    public static int highScore = 0;

    private void Awake()
    {
        instance = this; }
    

    void Start()
    {
        scoreText.text = "Points  " + score.ToString();
         
    }

    public void AddPoint()
    {
        score += para;
        scoreText.text = "Points  " +score.ToString();
         
    }
}
    // Update is called once per frame
    
