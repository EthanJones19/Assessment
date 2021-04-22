using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KillPlayerBehavior : MonoBehaviour
{
    //Function that checks if on collision been enter
    private void OnCollisionEnter(Collision collision)
    {
        //Checks if player has collide with game object and destroys the player
        if (collision.gameObject.CompareTag("Player"))
            Destroy(collision.gameObject);

        //Checks if player has collided with the game object and resets the scene
        if (collision.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(1);
    }
}
