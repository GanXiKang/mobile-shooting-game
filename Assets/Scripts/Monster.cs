using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    private float hp = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Bullet bullet = other.GetComponent<Bullet>();

            hp -= Bullet.atk;

            if (hp <= 0)
            {
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
}

