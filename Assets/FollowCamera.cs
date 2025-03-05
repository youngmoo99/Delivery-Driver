using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{   
    //카메라가 자동차의 중앙을 따라 다녀야함 
    [SerializeField]
    GameObject thingToFollow;
    // Update is called once per frame
    void LateUpdate()
    {   
        //z축추가로 카메라를 약간 띄워줘야함
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
