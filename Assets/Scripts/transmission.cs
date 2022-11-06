using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transmission : MonoBehaviour
{
    public Transform transm;
    public Transform player;
    bool istransm;
    
    void Start()
    {
        
    }
    void Update()
    {
        if (istransm == true)
        {
            Vector3 gogogo = transm.transform.position;
            player.transform.position = gogogo;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            istransm = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            istransm = false;
        }
    }
}
