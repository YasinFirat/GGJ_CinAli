using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score
{
    public float CalculateHightScore(int currentScore)
    {
        if (currentScore > PlayerPrefs.GetInt("HightScore"))
        {
            PlayerPrefs.SetInt("HightScore", currentScore);
            return currentScore;
        }
        else
        {
            return PlayerPrefs.GetInt("HightScore");
        }
    }
    public float GetHightScore()
    {
        return PlayerPrefs.GetInt("HightScore");
    }
}
