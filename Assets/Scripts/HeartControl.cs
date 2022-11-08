using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartControl : MonoBehaviour
{
    public static float heart = 100;
    public Text heartText;

    void Update()
    {
        heartText.text = heart.ToString();
    }
}
