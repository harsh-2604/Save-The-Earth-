using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class scoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highScoreText;

    private void Update()
    {
        scoreText.text = "SCORE: " + meteroidSpwaner.totalScore.ToString();
        highScoreText.text = "HIGHSCORE: " + meteroidSpwaner.highScore.ToString();
    }
}
