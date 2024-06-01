using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // [SerializeField] is used to controle directly from unity
    // [SerializeField] float x = 0;
    //[SerializeField] float y = 0;
    //[SerializeField] float z = 0;
    [SerializeField] float moveSpeed = 10f;
    void Start()
    {
        printInstruction();
    }

    // Update is called once per frame
    void Update()
    {
       movePlayer();
    }

    void printInstruction() {
        Debug.Log("Welcome in game");
        Debug.Log("You can move player by using arrow keys");
    }

    void movePlayer() {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed; //Time.deltaTime to have fixed fps in all devices 
        float z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(x, 0, z);
    }
}
