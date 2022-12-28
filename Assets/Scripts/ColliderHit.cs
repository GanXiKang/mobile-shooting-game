using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderHit : MonoBehaviour
{
    public AudioSource bGm;
    public AudioClip hit;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            HeartControl.heart -= 5;
            bGm.PlayOneShot(hit);
        }
    }
}
