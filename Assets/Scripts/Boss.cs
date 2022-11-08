using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private float hp = 325f;

    public GameObject enemyBullet;

    public Transform enemyFirePoint;
    public Transform enemyFirePoint1;
    public Transform enemyFirePoint2;

    public static float speed = 5f;
    public float timer = 0;
    public float timePeriod = 3f;

    void Update()
    {
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

            if (hp <= 0)
            {
                Destroy(gameObject);
                CoinScore.Score += 10;
            }
        }
    }
}
