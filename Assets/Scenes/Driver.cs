using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        //회전 x,y,z
        //transform.Rotate(0,0,45);
    }

    // Update is called once per frame
    void Update()
    {   
        transform.Rotate(0,0,0.1f); // 오브젝트 회전
        transform.Translate(0,0.01f,0); // 오브젝트 이동 
    }
}
