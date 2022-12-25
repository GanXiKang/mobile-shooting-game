using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class MonsterSmall : MonoBehaviour
{
    private float hp = 75f;
    private NavMeshAgent agent;

    public GameObject enemyBullet;
    public GameObject enemySmall;

    public Transform enemyPoint;
    public Transform enemyFirePoint;
    public Transform target;

    public static float speed = 5f;
    public float timer = 0;
    public float timePeriod = 1f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        timer += Time.deltaTime;

        Chase();

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
            
            if (hp <= 0)
            {
                Destroy(gameObject);
                CoinScore.Score += 2;
            }
        }
    }
    void Chase()
    {
        agent.SetDestination(target.transform.position);
    }
}
