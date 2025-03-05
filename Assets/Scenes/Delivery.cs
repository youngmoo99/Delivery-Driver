using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{   
    //기본 false
    bool hasPackage;
    [SerializeField]
    Color32 hasPackageColor = new Color32(1,1,1,1); //rgb, A값 

    [SerializeField]
    Color32 noPackageColor = new Color32(1,1,1,1); //rgb, A값 

    [SerializeField]
    float destoryDelay = 0.5f;

    SpriteRenderer spriteRenderer; 

    void Start()
    {   
        //getcomponent 특정한 컴포넌트를 찾으라고 명령
       spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void OnCollisionEnter2D(Collision2D other) { //충돌 감지 메서드 
        Debug.Log("Ouch!");

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if( other.tag =="Package" && !hasPackage) {
            Debug.Log("Package Picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destoryDelay);
        } else if (other.tag == "Customer" && hasPackage) {
            Debug.Log("Package Delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        } 
    }


}
