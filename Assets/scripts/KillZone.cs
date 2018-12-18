using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KillZone : MonoBehaviour {

    //Scene to load on Guardian/Kill Zone Detection//
    public string Kill = "1";

    //Load the set scene on collision//
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(Kill);
        }
    }
}
