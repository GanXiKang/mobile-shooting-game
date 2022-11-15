using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void Update()
    {
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
