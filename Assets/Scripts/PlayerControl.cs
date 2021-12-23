using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody SphereBall;
    public AudioClip AC;
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
    //private void OnCollisionEnter(Collision collision)
    //{
    //    //Debug.Log("Crash!");
    //    if(collision.gameObject.tag == "Item")
    //    {
    //        Destroy(collision.gameObject);
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Item")
        {
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(AC, transform.localPosition);
        }
    }

}
