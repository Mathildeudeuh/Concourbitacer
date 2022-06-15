using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
<<<<<<< Updated upstream
    public static Score instance;
=======
>>>>>>> Stashed changes
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    int score = 0;
    int highscore = 0;

<<<<<<< Updated upstream
    public void Awake()
    {
        instance = this;
    }

=======
>>>>>>> Stashed changes
    private void Start()
    {
        scoreText.text = score.ToString() + "POINTS";
        highscoreText.text = "HIGHSCORE:" + highscore.ToString();
    }

<<<<<<< Updated upstream
    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + "POINTS";

    }
=======

>>>>>>> Stashed changes
}
