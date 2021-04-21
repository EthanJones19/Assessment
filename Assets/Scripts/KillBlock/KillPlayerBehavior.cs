using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KillPlayerBehavior : MonoBehaviour
{
  
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            Destroy(collision.gameObject);

        if (collision.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(0);

    }


}
