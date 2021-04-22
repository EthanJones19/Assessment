using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGameBehavior : MonoBehaviour
{
    //Function that plays the game
    public void PlayGame()
    {
        //Loads the first scene
        SceneManager.LoadScene(1);
    }
}
