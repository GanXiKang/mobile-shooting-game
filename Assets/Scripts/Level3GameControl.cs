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
            SceneManager.LoadScene(3);
        }
        if (Input.GetKey("f1"))
        {
            SceneManager.LoadScene(2);
        }
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}
