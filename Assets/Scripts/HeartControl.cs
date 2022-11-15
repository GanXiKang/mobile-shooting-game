using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartControl : MonoBehaviour
{
    public static float heart = 100;
    public static float TotalHeart = 0;
    public Text heartText;
    public GameObject LoseText;
    public GameObject RestartText;
    public GameObject Player;

    void Update()
    {
        heartText.text = heart.ToString();

        if (heart <= 0) 
        {
            heart = 0;
            LoseText.SetActive(true);
            RestartText.SetActive(true);
            Player.SetActive(false);
        }
    }
}
