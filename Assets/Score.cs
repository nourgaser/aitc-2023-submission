using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text scoreText;
    [SerializeField] int score = 0;

    public static Action scored;
    void Start()
    {
        Collectable.collected += IncScore;
        scoreText = GetComponent<Text>();
    }

    void IncScore()
    {
        score++;
        scoreText.text = "Score: " + score;
        scored?.Invoke();
    }
}
