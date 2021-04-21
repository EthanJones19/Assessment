using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float _player;
    private bool _grounded = false;
    public float JumpForce = 5.0f;



    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();

    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0) && _grounded)
            _rigidbody.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
            _grounded = true;


    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject)
            _grounded = false;
    }

}





