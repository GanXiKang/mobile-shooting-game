using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    public Text loadingText;

    private float num = 0;
    private float maxNum = 100;
    private float timer = 0;
    private float timePeriod = 1.5f;
    void Update()
    {
        timer += Time.deltaTime;

        if (num < maxNum)
        {
            num++;
        }

        loadingText.text = "Loading... " + num + "%";

        if (num == maxNum)
        {
            num = maxNum;
        }

        if (timer >= timePeriod)
        {
            //SceneManager.LoadScene("NextLevel");
        }
    }
}
