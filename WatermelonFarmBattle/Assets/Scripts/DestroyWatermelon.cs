using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWatermelon : MonoBehaviour
{

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Animal"){
            Destroy(this.gameObject); 
        }
    }
}