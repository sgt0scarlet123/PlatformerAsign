using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour { 
    
    //Key//
    public static int KeyA;

    //Key Amount// 

    public int amount = 1;
    //Key Spin Speed "Animation"//

    private float SpinSpeed = 180;

    //Void Start: Sets the object collider//
    private void Start()
{
    GetComponent<BoxCollider2D>();
}

    //On collider collision with the player remove the object from the scene And add the set amunt of value to the KeyAmount//
    private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.tag == ("Player"))
    {
        Destroy(gameObject);
        Key.KeyA += amount;
    }

}

//The spin speed of the Key "Animation"//
private void Update()
{
    transform.Rotate(0, SpinSpeed * Time.deltaTime, 0);
}


}

