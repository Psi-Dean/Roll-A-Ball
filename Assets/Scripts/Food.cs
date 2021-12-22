using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.5f;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, speed);
    }
}
