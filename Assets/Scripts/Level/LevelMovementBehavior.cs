using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMovementBehavior : MonoBehaviour
{
    public float HorizontalSpeed = 3;


    void Update()
    {
        transform.position -= new Vector3(HorizontalSpeed, 0, 0) * Time.deltaTime;
    }

}
