using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4GameControl : MonoBehaviour
{
    void Update()
    {
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemys.Length == 0)
        {
            SceneManager.LoadScene(4);
            CoinScore.LV4TotalScore = CoinScore.Score;
            HeartControl.LV4TotalHeart = HeartControl.heart;
        }
        if (Input.GetKey("f1"))
        {
            SceneManager.LoadScene(3);
            CoinScore.Score = CoinScore.LV3TotalScore;
            HeartControl.heart = HeartControl.LV3TotalHeart; 
        }
    }
}
