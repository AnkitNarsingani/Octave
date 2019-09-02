using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text scoreText;
    public Text gameoverUI, gamewinUI;
    int totalScore = 0;

    void Start()
    {
        UpdateScore();
    }

    public void AddScore(int temp)
    {
        totalScore += temp;
        UpdateScore();
    }

    void UpdateScore()
    {
        if (totalScore < 9)
        {
            scoreText.text = "0" + totalScore.ToString();
            gamewinUI.text = "0" + totalScore.ToString();
            if (gameoverUI == null)
                return;
            gameoverUI.text = "0" + totalScore.ToString();

        }
        else
        {
            scoreText.text = totalScore.ToString();
            gamewinUI.text = totalScore.ToString();
            if (gameoverUI == null)
                return;
            gameoverUI.text = totalScore.ToString();
        }
    }
}
