using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    public GameObject coin;
    public GameObject coinPoint;

    private float hp = 200f;
    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Destroy(other.gameObject);
            hp -= Bullet.atk;

            if (hp == 0) 
            {
                Destroy(gameObject);
                Instantiate(coin, coinPoint.transform.position, transform.rotation);
                Instantiate(coin, coinPoint.transform.position + new Vector3(1f,0,0), transform.rotation);
                Instantiate(coin, coinPoint.transform.position + new Vector3(0, 0, 1f), transform.rotation);
                Instantiate(coin, coinPoint.transform.position + new Vector3(0, 0, -1f), transform.rotation);
                Instantiate(coin, coinPoint.transform.position + new Vector3(-1f, 0, 0), transform.rotation);
                Instantiate(coin, coinPoint.transform.position + new Vector3(1f, 0, 1f), transform.rotation);
                Instantiate(coin, coinPoint.transform.position + new Vector3(-1f, 0, -1f), transform.rotation);
                Instantiate(coin, coinPoint.transform.position + new Vector3(1f, 0, -1f), transform.rotation);
                Instantiate(coin, coinPoint.transform.position + new Vector3(-1f, 0, 1f), transform.rotation);
            }
        }
    }
}
