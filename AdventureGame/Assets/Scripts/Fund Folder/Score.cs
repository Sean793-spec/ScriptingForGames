using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    int score = 0;
    int highScore = 0;
    void Start()
    {
        scoreText.text = score.ToString() + "Points";
        highScoreText.text = "HighScore" + highScore.ToString();
    }

    // Update is called once per frame
    public void addScore(int points)
    {
        
    }
}
