using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    private float hp = 325f;
    private float hpMax = 325f;

    public GameObject enemyBullet;
    public GameObject hpBar;
    public Image hpRed;

    public Transform enemyFirePoint;
    public Transform enemyFirePoint1;
    public Transform enemyFirePoint2;

    public static float speed = 5f;
    public float timer = 0;
    public float timePeriod = 3f;

    void Update()
    {
        Vector3 offset = new Vector3(0, 100, 0);
        Vector3 p = Camera.main.WorldToScreenPoint(transform.position);
        hpBar.transform.position = p + offset;

        timer += Time.deltaTime;

        if (timer >= timePeriod)
        {
            Instantiate(enemyBullet, enemyFirePoint.transform.position, transform.rotation);
            Instantiate(enemyBullet, enemyFirePoint1.transform.position, transform.rotation);
            Instantiate(enemyBullet, enemyFirePoint2.transform.position, transform.rotation);
            timer = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Destroy(other.gameObject);

            hp -= Bullet.atk;
            float sx = hp / hpMax;
            if (hp <= 0)
            {
                sx = 0;
                Destroy(gameObject);
                CoinScore.Score += 10;
            }
            hpRed.rectTransform.localScale = new Vector3(sx, 1, 1);
        }
    }
}
