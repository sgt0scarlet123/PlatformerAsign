using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //Score//
    public static int score;
    public static bool Passive;
    public static bool Neutral;
    //Score Amount// 
    public int amount = 1;
    //Coin Spin Speed "Animation"//
    private float SpinSpeed = 180;

    //Void Start: Sets the object collider//
    private void Start()
    {
        GetComponent<CircleCollider2D>();
    }

    //On collider collision with the player remove the object from the scene And add the set amunt of value to the score//
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Player") && BossTrigger.Trigger == false || Passive == true)
        {
            Destroy(gameObject);
            Coin.score += amount;
        }

    }

    //The spin speed of the coin "Animation"//
    private void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            Passive = true;
        }
        else if (Input.GetKey(KeyCode.L))
        {
            Passive = false;
        }
        transform.Rotate(0, SpinSpeed * Time.deltaTime, 0);
    }


}
