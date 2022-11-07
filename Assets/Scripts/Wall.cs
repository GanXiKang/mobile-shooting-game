using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "bullet") 
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "EnemyBullet") 
        {
            Destroy(other.gameObject);
        }
    }
}
