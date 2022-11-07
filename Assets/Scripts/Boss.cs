using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private float hp = 300f;

    public GameObject enemyBullet;

    public Transform enemyFirePoint;
    public Transform enemyFirePoint1;
    public Transform enemyFirePoint2;
    public Transform enemyFirePoint3;
    public Transform target;

    public static float speed = 5f;
    public float timer = 0;
    public float timePeriod = 0.8f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timePeriod)
        {
            Instantiate(enemyBullet, enemyFirePoint.transform.position, transform.rotation);
            Instantiate(enemyBullet, enemyFirePoint1.transform.position, transform.rotation);
            Instantiate(enemyBullet, enemyFirePoint2.transform.position, transform.rotation);
            Instantiate(enemyBullet, enemyFirePoint3.transform.position, transform.rotation);
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
            }
        }
    }
}
