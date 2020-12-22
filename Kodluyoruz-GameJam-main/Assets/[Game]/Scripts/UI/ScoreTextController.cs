using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextController : MonoBehaviour
{
    // Start is called before the first frame update
    Text scoreText;
    public Text ScoreText { get { return (scoreText == null) ? scoreText = GetComponent<Text>() : scoreText; } }
    void Start()
    {
        ScoreText.text = ScoreManager.Instance.score.ToString();
    }

    private void OnEnable()
    {
        EventManager.OnScore.AddListener(UpdateScoreText);
        EventManager.OnMiss.AddListener(UpdateScoreText);
    }

    private void OnDisable()
    {
        EventManager.OnScore.RemoveListener(UpdateScoreText);
        EventManager.OnMiss.RemoveListener(UpdateScoreText);
    }

    private void UpdateScoreText()
    {
        ScoreText.text = ScoreManager.Instance.score.ToString();
    }
}
