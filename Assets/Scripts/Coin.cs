using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 45f * Time.deltaTime, 0);
        transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            Destroy(gameObject);
            CoinScore.Score += 5;
        }
    }
}
