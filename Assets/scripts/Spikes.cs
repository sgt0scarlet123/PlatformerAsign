using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Spikes : MonoBehaviour {
    //The "Game over" Scene//
    public string Spike = "1";

    //Load the "Game over" scene if Player detected//
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player"){
            SceneManager.LoadScene(Spike);
        }
    }
}
