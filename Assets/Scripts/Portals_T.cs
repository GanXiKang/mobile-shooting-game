using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portals_T : MonoBehaviour
{
    public Transform transm;
    public GameObject transmActive;
    public Transform player;

    bool istransm;

    void Update()
    {
        if (istransm == true)
        {
            StartCoroutine(TimePeriod());
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
    IEnumerator TimePeriod() 
    {
        player.transform.position = transm.transform.position;
        transmActive.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        transmActive.SetActive(true);
    }
}
