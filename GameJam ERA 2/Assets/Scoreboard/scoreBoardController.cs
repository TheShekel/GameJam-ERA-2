using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class scoreBoardController : MonoBehaviour
{
    public UnityEvent OnScoreChanged;

    public int Score{ get; private set;}

    public void AddScore (int scoreChangeAmount)
    {
        Score += scoreChangeAmount;
        OnScoreChanged.Invoke();
    }
}
