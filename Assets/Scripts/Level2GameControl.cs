using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2GameControl : MonoBehaviour
{
    void Update()
    {
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemys.Length == 0)
        {
            SceneManager.LoadScene(3);
            CoinScore.LV2TotalScore = CoinScore.Score;
        }
        if (Input.GetKey("f1"))
        {
            SceneManager.LoadScene(2);
            HeartControl.heart = 100;
            CoinScore.Score = CoinScore.LV1TotalScore;
        }
    }
}
