using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMovementBehavior : MonoBehaviour
{
    [SerializeField]
    public float HorizontalSpeed = 3;

    //Function that updates the position
    void Update()
    {
        //Transforms the position base on horizontal speed and time
        transform.position -= new Vector3(HorizontalSpeed, 0, 0) * Time.deltaTime;
    }

}
