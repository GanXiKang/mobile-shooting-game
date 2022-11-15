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
            SceneManager.LoadScene(5);
            CoinScore.TotalScore = CoinScore.Score;
            HeartControl.TotalHeart = HeartControl.heart;
        }
        if (Input.GetKey("f1"))
        {
            SceneManager.LoadScene(4);
            CoinScore.Score = CoinScore.TotalScore;
            HeartControl.heart = HeartControl.TotalHeart; 
        }
    }
}
