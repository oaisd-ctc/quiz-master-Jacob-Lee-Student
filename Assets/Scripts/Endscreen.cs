using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Endscreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finialScoreText;
    ScoreKeeper scoreKeeper;
    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    public void ShowFinalScore() {
        finialScoreText.text = "Congratulations!\nYou got a score of " +
        scoreKeeper.CalculateScore() + "%";
    }
}
