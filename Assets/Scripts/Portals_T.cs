using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portals_T : MonoBehaviour
{
    public Transform transm;
    public Transform player;

    bool istransm;

    void Update()
    {
        if (istransm == true)
        {
            if (Input.GetKey("t"))
            {

                player.transform.position = transm.transform.position;
            }
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
