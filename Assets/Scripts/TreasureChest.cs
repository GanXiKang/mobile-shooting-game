using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest : MonoBehaviour
{
    public GameObject coin;
    public GameObject Hp;
    public GameObject Point;
    public AudioSource bGM;
    public AudioClip openBox;

    private float hp = 150f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet")
        {
            Destroy(other.gameObject);
            hp -= Bullet.atk;

            if (hp == 0) 
            {
                Destroy(gameObject);
                bGM.PlayOneShot(openBox);
                Instantiate(coin, Point.transform.position, transform.rotation);
                Instantiate(coin, Point.transform.position + new Vector3(1f,0,0), transform.rotation);
                Instantiate(coin, Point.transform.position + new Vector3(0, 0, 1f), transform.rotation);
                Instantiate(coin, Point.transform.position + new Vector3(0, 0, -1f), transform.rotation);
                Instantiate(coin, Point.transform.position + new Vector3(-1f, 0, 0), transform.rotation);
                Instantiate(coin, Point.transform.position + new Vector3(1f, 0, 1f), transform.rotation);
                Instantiate(coin, Point.transform.position + new Vector3(-1f, 0, -1f), transform.rotation);
                Instantiate(coin, Point.transform.position + new Vector3(1f, 0, -1f), transform.rotation);
                Instantiate(coin, Point.transform.position + new Vector3(-1f, 0, 1f), transform.rotation);
                Instantiate(Hp, Point.transform.position, transform.rotation);
            }
        }
    }
}
