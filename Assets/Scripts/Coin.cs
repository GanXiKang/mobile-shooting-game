using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float Timer = 0;
    void Update()
    {
        Timer++;
        if (Timer < 200f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.01f, transform.position.z);
            Timer = 0;
        }
        transform.Rotate(0, 45f * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Collect") 
        {
            Destroy(gameObject);
            CoinScore.Score += 5;
        }
    }
}
