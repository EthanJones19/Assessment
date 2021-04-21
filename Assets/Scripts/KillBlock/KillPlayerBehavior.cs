using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayerBehavior : MonoBehaviour
{
  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
            Destroy();

    }

    public void Destroy()
    {
        Destroy();
    }
}
