using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public static Score instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    int score = 0;
    int highscore = 0;

    public GameObject spawner;
    public GameObject plante;
    public GameObject plante1;



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

    public void SpawnPlante()
    {
        var pointEngrais = FindObjectOfType<Nourrir>();
        var pointEau = FindObjectOfType<Arroser>();

        if (pointEngrais.scoreEngrais == 10)
        {
            if (pointEau.scoreEau == 10)
            {
                Instantiate(plante, spawner.transform.position, spawner.transform.rotation);
                Debug.Log("oui");
            }
        }

        if (pointEngrais.scoreEngrais >= 30)
        {
            if (pointEau.scoreEau >= 30)
            {
                Destroy(plante);
                Instantiate(plante1, spawner.transform.position, spawner.transform.rotation);
            }

        }
    }
}
