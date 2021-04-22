using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _rigidbody;
    [SerializeField]
    private bool _grounded = false;
    [SerializeField]
    public float JumpForce = 5.0f;


    //Function that starts up the rigid body
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    //Updates the mouse button and force
    void Update()
    {
        //Checks if mouse button has been pressed down and grounded to add jump force
        if (Input.GetMouseButtonDown(0) && _grounded)
            _rigidbody.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);

    }

    //Function that checks if on collision been enter
    private void OnCollisionEnter(Collision collision)
    {
        //Checks if game object is colliding with the ground
        if (collision.gameObject)
            _grounded = true;
    }

    //Function that checks if on collision been exited
    private void OnCollisionExit(Collision collision)
    {
        //Checks if the game object is not colliding with the ground
        if (collision.gameObject)
            _grounded = false;
    }

}





