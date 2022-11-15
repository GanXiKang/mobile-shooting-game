using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3GameControl : MonoBehaviour
{
    void Update()
    {
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemys.Length == 0)
        {
            SceneManager.LoadScene(4);
            CoinScore.TotalScore = CoinScore.Score;
            HeartControl.TotalHeart = HeartControl.heart;
        }
        if (Input.GetKey("f1"))
        {
            SceneManager.LoadScene(3);
            HeartControl.heart = 100;
            CoinScore.Score = CoinScore.TotalScore;
        }
    }
}

