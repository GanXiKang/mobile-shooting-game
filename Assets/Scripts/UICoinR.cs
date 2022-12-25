using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICoinR : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 45f * Time.deltaTime, 0);
    }
}
