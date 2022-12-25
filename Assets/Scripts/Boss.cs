using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Boss : MonoBehaviour
{
    private float hp = 350f;
    private float hpMax = 350f;
    private NavMeshAgent agent;

    public GameObject enemyBullet;
    public GameObject player;
    public GameObject hpBar;
    public Image hpRed;

    public Transform enemyFirePoint;
    public Transform enemyFirePoint1;
    public Transform enemyFirePoint2;

    public static float speed = 5f;
    public float timer = 0;
    public float timePeriod = 0.7f;
    public float chaseDistance = 25f;
    public float attackDistance = 20f;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        Vector3 offset = new Vector3(0, 100, 0);
        Vector3 p = Camera.main.WorldToScreenPoint(transform.position);
        hpBar.transform.position = p + offset;

        timer += Time.deltaTime;

        float distance = Vector3.Distance(transform.position, player.transform.position);

        if (distance <= chaseDistance)
        {
            Chase();
        }
        if (distance <= attackDistance)
        {
            Attack();
        }
        if (distance > chaseDistance)
        {
            Wander();
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
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, chaseDistance);
        Gizmos.DrawWireSphere(transform.position, attackDistance);
    }
    void Chase()
    {
        var tr = Quaternion.LookRotation(player.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(tr, transform.rotation, speed * Time.deltaTime);

        transform.position += transform.forward * speed * Time.deltaTime;
    }
    void Attack()
    {
        if (timer >= timePeriod)
        {
            Instantiate(enemyBullet, enemyFirePoint.transform.position, transform.rotation);
            Instantiate(enemyBullet, enemyFirePoint1.transform.position, transform.rotation);
            Instantiate(enemyBullet, enemyFirePoint2.transform.position, transform.rotation);
            timer = 0;
        }
    }
    void Wander()
    {
        if (timer < 3f)
        {
            transform.position = new Vector3(transform.position.x + 3f * Time.deltaTime, transform.position.y, transform.position.z);

            Quaternion targetRotation = Quaternion.Euler(0, 90, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);
        }
        if (timer > 3f && timer < 6f)
        {
            transform.position = new Vector3(transform.position.x - 3f * Time.deltaTime, transform.position.y, transform.position.z);

            Quaternion targetRotation = Quaternion.Euler(0, 270, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);
        }
        if (timer > 6f)
        {
            timer = 0;
        }
    }
}
