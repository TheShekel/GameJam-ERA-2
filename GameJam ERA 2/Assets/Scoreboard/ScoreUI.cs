using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.PlayerLoop;

public class ScoreUI : MonoBehaviour
{   
    private static int score = 0;
    private static TMP_Text _scoreNumbers;

    private void Awake()
    {
        _scoreNumbers = GetComponent<TMP_Text>();
    }

    public static void AddScore(int addScore)
    {
        score += addScore;
        UpdateScore();
    }

    public static void UpdateScore()
    {
        _scoreNumbers.text = $"Score: {score}";
    } 
}
