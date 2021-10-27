using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI text;

    int score;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        if(PlayerPrefs.HasKey("Coin"))
        {
            score = PlayerPrefs.GetInt("Coin");
        }
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "Coins: " + score.ToString();
    }
}
