using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    public static float Score = 0;
    public static float LV1TotalScore = 0;
    public static float LV2TotalScore = 0;
    public static float LV3TotalScore = 0;
    public static float LV4TotalScore = 0;
    public Text coinText;

    void Update()
    {
        coinText.text = Score.ToString();
    }
}
