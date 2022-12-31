using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove_WS : MonoBehaviour
{
   public float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer < 2f)
        {
            transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z + 3f * Time.deltaTime);

            Quaternion targetRotation = Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);

        }
        if (timer > 2f && timer < 4f)
        {
            transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z - 3f * Time.deltaTime);

            Quaternion targetRotation = Quaternion.Euler(0, 180, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);

        }
        if (timer > 4f)
        {
            timer = 0;
        }
    }
}
