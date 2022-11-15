using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 25 * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Collect")
        {
            Destroy(gameObject);
            HeartControl.heart = 100;
        }
    }
}
