using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;



public class Scoring : MonoBehaviour, IAddToScore
{
    public float currentScore;
    public Text ScoreNumber;

    UnityEvent event_scoringCheck;

    public void AddToScore(float addToScore)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (event_scoringCheck == null)
            event_scoringCheck = new UnityEvent();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreNumber.text = "Score: " + Mathf.Round(currentScore);
        
    }

    public void AddToScore()
    {
        currentScore = currentScore + IAddToScore;
    }
}
