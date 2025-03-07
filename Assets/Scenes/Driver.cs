using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{   
    [SerializeField]
    float steerSpeed = 0.1f;

    [SerializeField]    
    float moveSpeed = 0.01f;

    [SerializeField]
    float slowSpeed = 0.01f;

    [SerializeField]
    float boostSpeed = 0.02f;
    // Start is called before the first frame update
    void Start()
    {   
        //회전 x,y,z
        //transform.Rotate(0,0,45);
    }

    // Update is called once per frame
    void Update()
    {   
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount); // 오브젝트 회전
        transform.Translate(0,moveAmount,0); // 오브젝트 이동 
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag =="Boost") {
            Debug.Log("Move Faster");
            moveSpeed = boostSpeed;
        } else if (other.tag == "Bump") {
            Debug.Log("Move Slowly");
            moveSpeed = slowSpeed;
        }
    }
}
