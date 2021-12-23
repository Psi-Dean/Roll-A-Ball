using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody SphereBall;
    public AudioClip AC;
    public int score = 0;
    public Text scoreText;
    public GameObject GameWin;
    public float timer = 30;
    public GameObject timerText;
    public GameObject GameOver;
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
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timerText.GetComponent<Text>().text = "剩余时间：" + timer.ToString("00");
        }
        else 
        {
           GameOver.SetActive(true);
            Destroy(SphereBall);
        };

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
            score ++ ;
            scoreText.text = "分数：" + score;
            if(score == 17)
            {
                GameWin.SetActive(true);
                Destroy(SphereBall);
            }
        }
    }

}
