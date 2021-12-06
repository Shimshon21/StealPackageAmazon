using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public TextMeshProUGUI scoreCounterText;
    public int scoreValue;

    // Start is called before the first frame update
    void Start()
    {
        scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreCounterText.text = scoreValue.ToString();
    
    }

    public void AddScore()
    {
        scoreValue++;
    }
}
