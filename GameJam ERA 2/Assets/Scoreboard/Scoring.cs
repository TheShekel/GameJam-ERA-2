using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Scoring : MonoBehaviour
{
    public float currentScore;
    public Text ScoreNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreNumber.text = "Score: " + Mathf.Round(currentScore);
    }
}
