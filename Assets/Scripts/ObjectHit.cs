using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objHit : MonoBehaviour
{
     void OnCollisionEnter(Collision other) {
        //To change color of walls after collision

        if(other.gameObject.tag == "Player") {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }
        
    }
}
