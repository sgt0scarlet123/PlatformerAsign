using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTrigger : MonoBehaviour {
    //Boss Fight Trigger//
    public static bool Trigger;
    //Boss Zone Collider//
    public BoxCollider2D BossZone;

    //Makes the Sprites that need to be invisible well invisible and Gets BoxCollider component//
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        BossZone = GetComponent<BoxCollider2D>();
    }
    //If Player is detected entering this zone than set Trigger to true//
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Trigger = true;
             Destroy(gameObject);
        }
    }
        
    
}
