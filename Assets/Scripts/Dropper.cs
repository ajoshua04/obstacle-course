using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;

    MeshRenderer nRenderer ;
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        nRenderer =  GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        nRenderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
       if(Time.time > timeToWait)
       {
            nRenderer.enabled = true;
            rigidBody.useGravity = true;
       } 
    }
}
