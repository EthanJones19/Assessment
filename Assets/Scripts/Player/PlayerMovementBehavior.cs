using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    private Rigidbody _rigidbody;
    
    public float JumpForce = 5.0f;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        _rigidbody.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
    }


    public void OnCollisionStay(Collision collision)
    {

    }


}





