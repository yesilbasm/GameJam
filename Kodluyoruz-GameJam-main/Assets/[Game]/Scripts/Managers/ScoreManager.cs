using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : Singleton<ScoreManager>
{
    public int score = 0;
    public int scoreMultiplier = 1;
    public void ScoreDown()
    {
        if (score > 0)
        {
            score--;
        }
        
    }

    public void ScoreUp()
    {
        score += 1 * scoreMultiplier;
    }

    public void DoubleScore()
    {
        StartCoroutine(DoublePoints());
    }
    public IEnumerator DoublePoints()
    {
        scoreMultiplier = 2;
        yield return new WaitForSeconds(10);
        scoreMultiplier = 1;
    }
}
