using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    private float hp = 100f;
    private float maxHP = 100f;

    public GameObject enemyBullet;
    public GameObject enemySmall;
    public GameObject hpBar;
    public Image hpRed;

    public AudioSource bGM;
    public AudioClip defeat;

    public Transform enemyPoint;
    public Transform enemyFirePoint;
    public Transform target;

    public static float speed = 5f;
    public float timer = 0;
    public float timePeriod = 1f;
    void Update()
    {
        Vector3 offset = new Vector3(0, 100, 0);
        Vector3 p = Camera.main.WorldToScreenPoint(transform.position);
        hpBar.transform.position = p + offset;

        timer += Time.deltaTime;

        if (timer >= timePeriod)
        {
            Instantiate(enemyBullet, enemyFirePoint.transform.position, transform.rotation);
            timer = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Destroy(other.gameObject);

            hp -= Bullet.atk;
            float sx = hp / maxHP;
            hpRed.rectTransform.localScale = new Vector3(sx, 1, 1);
            if (hp <= 0)
            {
                hpBar.SetActive(false);
                Destroy(gameObject);
                bGM.PlayOneShot(defeat);
                CoinScore.Score += 3;
                Instantiate(enemySmall, enemyPoint.transform.position + new Vector3(1f, 0, 0), transform.rotation);
                Instantiate(enemySmall, enemyPoint.transform.position + new Vector3(-1f, 0, 0), transform.rotation);
            }
        }
    }
}

