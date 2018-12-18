using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour {
    //Unlock Animatoion//
    public Animator unlock;
    //InisibleWall//
    public BoxCollider2D Inviswall;

    //Void Start Gets Animator and BoxCollider components//
    private void Start()
    {
        unlock = GetComponent<Animator>();
        Inviswall = GetComponent<BoxCollider2D>();
    }
    //If 3 or more keys have been collected play unlock animation and disalble InvisWall//
    public void Update()
    {
        if (Key.KeyA == 3 || Key.KeyA >= 3)
        {
            unlock.SetTrigger("Unlock");
            Inviswall.enabled=false;
        }
    }

}
