using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartControl : MonoBehaviour
{
    public static float heart = 100;
    public static float LV3TotalHeart = 0;
    public static float LV4TotalHeart = 0;
    public Text heartText;
    public GameObject LoseText;
    public GameObject RestartText;

    void Update()
    {
        heartText.text = heart.ToString();

        if (heart <= 0) 
        {
            LoseText.SetActive(true);
            RestartText.SetActive(true);
        }
    }
}
