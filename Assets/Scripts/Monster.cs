using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private float hp = 100f;
    private CharacterController controller;

    public GameObject enemyBullet;
    public GameObject enemyFirePoint;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        StartCoroutine(KeepShooting());
    }

    void Fire()
    {
        Instantiate(enemyBullet, enemyFirePoint.transform.position, transform.rotation);
    }
    IEnumerator KeepShooting()
    {
        while (true)
        {
            Fire();

            yield return new WaitForSeconds(1.5f);
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
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
}

