using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody SphereBall;
    // Start is called before the first frame update
    void Start()
    {
       //Debug.Log("游戏开始"); 
       SphereBall = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float MoveHori = Input.GetAxis("Horizontal");
        float MoveVert = Input.GetAxis("Vertical");
        SphereBall.AddForce(new Vector3(MoveHori,0,MoveVert) * 2 );
    }
}
