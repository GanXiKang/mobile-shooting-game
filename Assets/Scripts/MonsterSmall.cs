using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class MonsterSmall : MonoBehaviour
{
    private float hp = 75f;
    private NavMeshAgent agent;

    public AudioSource bGM;
    public AudioClip defeat;

    public GameObject target;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
        target = GameObject.Find("Player");
    }
    void Update()
    {
        Chase();
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
                bGM.PlayOneShot(defeat);
                CoinScore.Score += 2;
            }
        }
    }
    void Chase()
    {
        agent.SetDestination(target.transform.position);
    }
}
