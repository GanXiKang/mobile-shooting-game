using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transposition : MonoBehaviour
{
    public Transform point;
    public Transform player;

    private bool isTransm;
    void Update()
    {
        if (isTransm == true)
        {
            player.transform.position = point.transform.position;
        }
    }
        private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player") 
        {
            isTransm = true;
        }
    }
}
