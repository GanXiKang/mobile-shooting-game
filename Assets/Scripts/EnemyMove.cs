using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer++;

        if (timer < 50f) 
        {
            transform.position = new Vector3(transform.position.x + 3f * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (timer > 50f && timer < 100f)
        {
            transform.position = new Vector3(transform.position.x - 3f * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (timer > 100f) 
        {
            timer = 0;
        }
    }
}
