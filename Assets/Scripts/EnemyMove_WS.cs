using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove_WS : MonoBehaviour
{
   public float timer = 0;

    void Update()
    {
        timer++;

        if (timer < 500f)
        {
            transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z + 3f * Time.deltaTime);

            Quaternion targetRotation = Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);

        }
        if (timer > 500f && timer < 1000f)
        {
            transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z - 3f * Time.deltaTime);

            Quaternion targetRotation = Quaternion.Euler(0, 180, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);

        }
        if (timer > 1000f)
        {
            timer = 0;
        }
    }
}
