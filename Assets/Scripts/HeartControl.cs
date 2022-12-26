using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartControl : MonoBehaviour
{
    public static float heart = 100;
    public static float TotalHeart;
    public Text heartText;
    public GameObject died;

    void Update()
    {
        heartText.text = heart.ToString();

        if (heart <= 0) 
        {
            heart = 0;
            StartCoroutine(DiedTime());
        }
    }
    IEnumerator DiedTime()
    {
        died.SetActive(true);
        yield return new WaitForSeconds(2f);
        died.SetActive(false);
    }
}
