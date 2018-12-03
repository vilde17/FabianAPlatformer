using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using UnityEngine.UI
public class ScoreTracker : MonoBehaviour
{   
    //Vissar vad jag ber den att säga eller skriva i textmeshpro som ligger i unity som en UI
    public TMPro.TextMeshProUGUI scoreText;
    public int totalScore;
    // Säger vad textmeshpro ska skriva i min UI vilket är en scoretracker vilket räknar min score
    private void Update()
    {
        scoreText.text = string.Format("score: {0}", totalScore);   
    }
}
