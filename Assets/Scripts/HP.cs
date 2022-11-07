using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 25 * Time.deltaTime, 0);
        transform.position = new Vector3(transform.position.x, 1f, transform.position.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            Destroy(gameObject);
        }
    }
}
