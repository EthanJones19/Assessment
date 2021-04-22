using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalBehavior : MonoBehaviour
{
    //Function that checks if on collision been enter
    public void OnCollisionEnter(Collision collision)
    {
        //Checks if the player collides with game object and loads second scene
        if (collision.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(2);
    }
}
