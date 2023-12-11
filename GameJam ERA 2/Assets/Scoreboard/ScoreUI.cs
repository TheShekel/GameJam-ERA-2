using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    private TMP_Text _scoreNumbers;

    private void Awake()
    {
        _scoreNumbers = GetComponent<TMP_Text>();
    }

     public void UpdateScore(scoreBoardController scoreBoardController)
        {
            _scoreNumbers.text = $"Score: {scoreBoardController.Score}";
        } 
}
