using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1GameControl : MonoBehaviour
{
    void Update()
    {
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemys.Length == 0)
        {
            SceneManager.LoadScene(2);
            CoinScore.TotalScore = CoinScore.Score;
        }
        if (Input.GetKey("f1"))
        {
            SceneManager.LoadScene(1);
            HeartControl.heart = 100;
            CoinScore.Score = 0;
        }
    }
}
