using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScoreAllocator : MonoBehaviour
{
    [SerializeField]
    private int scoreForKill;

    private scoreBoardController _scoreBoardController;

    private void Awake()
    {
        _scoreBoardController = FindObjectOfType<scoreBoardController>();
    }

    public void AllocateScore()
    {
        _scoreBoardController.AddScore(scoreForKill);
    }
}
