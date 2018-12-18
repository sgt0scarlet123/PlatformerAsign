using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class restart : MonoBehaviour {
    //If "game over" scene is loaded play the set animation// 
    public Animator Death;

    //If reset button is pressed reload the previous scene and set score to 0//
    void Update () {
        if (Input.GetKey(KeyCode.S))
        {
            Coin.score = 0;
            Key.KeyA = 0;
            BossTrigger.Trigger = false;
            SceneManager.LoadScene("Menu");
        }
	}
}
