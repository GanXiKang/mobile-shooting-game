using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    public static float Score = 0;
    public static float TotalScore = 0;
    public Text coinText;

    void Update()
    {
        coinText.text = Score.ToString();
    }
}
