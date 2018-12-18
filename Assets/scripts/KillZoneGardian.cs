using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KillZoneGardian : MonoBehaviour {
    //Scene to load on Guardian/Kill Zone Detection//
    public string GuardianKill = "GardianKill";
    
    //Load the set scene on collision//
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(GuardianKill);
        }
    }

}
