using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level7GameControl : MonoBehaviour
{
    private float timer = 0;
    private float timePeriod = 1.5f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timePeriod)
        {
            SceneManager.LoadScene(1);
        }
    }
}
