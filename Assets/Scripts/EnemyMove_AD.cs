using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove_AD : MonoBehaviour
{
    public float timer = 0;
    void Update()
    {
        timer++;

        if (timer < 500f)
        {
            transform.position = new Vector3(transform.position.x + 3f * Time.deltaTime, transform.position.y, transform.position.z);

            Quaternion targetRotation = Quaternion.Euler(0, 90, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);
        }
        if (timer > 500f && timer < 1000f)
        {
            transform.position = new Vector3(transform.position.x - 3f * Time.deltaTime, transform.position.y, transform.position.z);

            Quaternion targetRotation = Quaternion.Euler(0, 270, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);
        }
        if (timer > 1000f)
        {
            timer = 0;
        }
    }
}
