using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using UnityEngine.UI
public class ScoreTracker : MonoBehaviour
{
    public TMPro.TextMeshProUGUI scoreText;
    public int totalScore;

    private void Update()
    {
        scoreText.text = string.Format("score: {0}", totalScore);   
    }
}
