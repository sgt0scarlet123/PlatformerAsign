using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTriggerNe : MonoBehaviour {
    //The Opposit of BossTrigger it turns of Trigger Rather than turning it on//
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            BossTrigger.Trigger = false;
        }
    }
}
