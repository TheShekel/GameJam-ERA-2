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
        Debug.Log(_scoreNumbers);
    }

    public static void AddScore(int addScore)
    {
        score += addScore;
        UpdateScore();
    }

    public static void UpdateScore()
    {
        Debug.Log(_scoreNumbers);
        _scoreNumbers.text = $"Score: {score}";
    } 
}
