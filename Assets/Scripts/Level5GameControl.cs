using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level5GameControl : MonoBehaviour
{ 
    void Update()
    {
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemys.Length == 0)
        {
            SceneManager.LoadScene(6);
        }
        if (HeartControl.heart == 0)
        {
            StartCoroutine(DiedTime());
        }
        IEnumerator DiedTime()
        {
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(5);
            HeartControl.heart = 100;
            CoinScore.Score = CoinScore.TotalScore;
        }
    }
}
