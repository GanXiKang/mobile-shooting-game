using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleMan : MonoBehaviour
{
    public GameObject playerPosition;
    public GameObject enemyPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = (playerPosition.transform.position + enemyPosition.transform.position) / 2;
    }
}
