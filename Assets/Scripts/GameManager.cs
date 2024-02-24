using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;


    private void Start()
    {
        score = 0;
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
