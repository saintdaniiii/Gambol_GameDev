using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Result : MonoBehaviour
{
    private int finalScore;
    private int bestScore;

    public TextMeshProUGUI finalscore;
    public TextMeshProUGUI bestscore;

    // Start is called before the first frame update
    void Start()
    {
        finalScore = PlayerPrefs.GetInt("score");

        finalscore.text = "Score: " + PlayerPrefs.GetInt("score").ToString();

        bestScore = PlayerPrefs.GetInt("bestscore", bestScore);
    }

    // Update is called once per frame
    void Update()
    {
        if (finalScore > bestScore)
        {
            bestScore = finalScore;
            bestscore.text = "Best Score: " + bestScore.ToString();

            PlayerPrefs.SetInt("bestscore", bestScore);
            PlayerPrefs.Save();
        }
        else if (finalScore < bestScore)
        {
            bestscore.text = "Best Score: " + bestScore.ToString();
        }
    }

    public void resetScore()
    {
        finalScore = 0;
        bestScore = 0;

        PlayerPrefs.SetInt("bestscore", bestScore);
        PlayerPrefs.Save();

        bestscore.text = "Best Score: " + bestScore.ToString();
        finalscore.text = "Score: " + finalScore.ToString();
    }
}
