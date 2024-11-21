using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Score : MonoBehaviour
{
    public static Score instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    int score = 0;
    int highScore = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        scoreText.text = score.ToString() + "Points";
        highScoreText.text = "HighScore" + highScore.ToString();
    }

    // Update is called once per frame
    public void AddPoints()
    {
        score += 1;
        scoreText.text = score.ToString() + "Points";
        if (score > highScore)
            PlayerPrefs.SetInt("HighScore", score);
    }
}
