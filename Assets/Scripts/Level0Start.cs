using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level0Start : MonoBehaviour
{
    public void Click() 
    {
        SceneManager.LoadScene(1);
        HeartControl.heart = 100;
        CoinScore.Score = 0;
    }
}
