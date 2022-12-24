using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Portals_T : MonoBehaviour
{
    public Transform transm;
    public GameObject transmActive;
    public Transform player;

    public GameObject teleportText;

    bool istransm;

    void Update()
    {
        if (istransm == true)
        {
            StartCoroutine(TimePeriod());
            //teleportText.SetActive(true);
            //if (Input.GetKey("t"))
            //{
            //    player.transform.position = transm.transform.position;
            //}
        }
        if (istransm == false)
        {
            teleportText.SetActive(false);
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
        yield return new WaitForSeconds(2f);
        transmActive.SetActive(true);
    }
}
