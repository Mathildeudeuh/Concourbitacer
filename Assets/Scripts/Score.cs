using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public static Score instance;

    //private Arroser arroser;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    int score = 0;
    int highscore = 0;


    public void Awake()
    {
        instance = this;
    }


    private void Start()
    {
        scoreText.text = "POINTS : " + score.ToString();
        highscoreText.text = "HIGHSCORE:" + highscore.ToString();
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = "POINTS : " + score.ToString();
    }

}
