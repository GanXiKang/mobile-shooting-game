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

    public AudioSource bGM;
    public AudioClip diedAudio;

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
        bGM.PlayOneShot(diedAudio);
        yield return new WaitForSeconds(5f);
        died.SetActive(false);
    }
}
