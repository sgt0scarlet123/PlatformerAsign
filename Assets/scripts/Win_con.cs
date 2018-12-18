using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Win_con : MonoBehaviour {
    //Minimum score required to win at the goal//
    public int minimumScoreNeeded = 1;
    //Game "win" scene//
    public string SceneToLoad = "Win";

    //If the player collide with the goal then load the "win" scene//
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Coin.score >= minimumScoreNeeded)
        {
            SceneManager.LoadScene(SceneToLoad);
        }   
    }




}
