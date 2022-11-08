using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private float hp = 100f;

    public GameObject enemyBullet;
    public GameObject enemySmall;

    public Transform enemyPoint;
    public Transform enemyFirePoint;
    public Transform target;

    public static float speed = 5f;
    public float timer = 0;
    public float timePeriod = 1f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timePeriod)
        {
            Instantiate(enemyBullet, enemyFirePoint.transform.position, transform.rotation);
            timer = 0;
        }

        var tr = Quaternion.LookRotation(target.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(tr, transform.rotation, speed * Time.deltaTime);
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
                CoinScore.Score += 3;
                Instantiate(enemySmall, enemyPoint.transform.position + new Vector3(1f, 0, 0), transform.rotation);
                Instantiate(enemySmall, enemyPoint.transform.position + new Vector3(-1f, 0, 0), transform.rotation);
            }
        }
    }
}

