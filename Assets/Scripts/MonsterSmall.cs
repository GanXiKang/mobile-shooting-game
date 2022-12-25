using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterSmall : MonoBehaviour
{
    private float hp = 75f;

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
                CoinScore.Score += 2;
            }
        }
    }
}
