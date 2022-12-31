using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove_WD : MonoBehaviour
{
    public float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer < 1.5f)
        {
            transform.position = new Vector3(transform.position.x + 3f * Time.deltaTime, transform.position.y, transform.position.z + 3f * Time.deltaTime);

            Quaternion targetRotation = Quaternion.Euler(0, 45, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);

        }
        if (timer > 1.5f && timer < 3f)
        {
            transform.position = new Vector3(transform.position.x - 3f * Time.deltaTime, transform.position.y, transform.position.z - 3f * Time.deltaTime);

            Quaternion targetRotation = Quaternion.Euler(0, 225, 0);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);

        }
        if (timer > 3f)
        {
            timer = 0;
        }
    }
}
