using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level5GameControl : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemys.Length == 0)
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKey("f1"))
        {
            SceneManager.LoadScene(4);
        }
    }
}
