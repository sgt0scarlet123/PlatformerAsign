using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Ene_I_Mean_Friend : MonoBehaviour
{
    //Enemy Speed//
    public float speed = 1.5f;

    //flips direction//
    public CircleCollider2D EdgeCheck;

    //Enemy hit box only killing the player//
    public BoxCollider2D Hit;
    public BoxCollider2D DEADYOUMONSTER;

    //Body to move//
    private Rigidbody2D RBody;

    //Direction at start and change direction if false//
    public bool Left = true;

    //Flip//
    public Transform Flip;

    //"Game over" scene//
    private string SCene = "1";

    //sets body to move and the colliders that is used in diffrent situtions//
    private void Start()

    {
        RBody = GetComponent<Rigidbody2D>();
        EdgeCheck = GetComponent<CircleCollider2D>();
        Hit = GetComponent<BoxCollider2D>();
        Flip = GetComponent<Transform>();
        DEADYOUMONSTER = GetComponentInChildren<BoxCollider2D>();
    }

    //speed and direction//
    private void Update()
    {
        if (Left == true)
        {
            RBody.velocity = (-(Vector2)transform.right * speed);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            RBody.velocity = ((Vector2)transform.right * speed);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    //if no collison or InvisWall collision flip. If Player is detected jumping on this object than destroy object and change route to Neuteral//
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "InvisWall")
        {
            Left = !Left;
        }
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            Coin.Neutral = true;
        }

    }

    //if player is detected than load "Game over" scene//
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            SceneManager.LoadScene(SCene);
        }

        if (collision.collider.tag == "InvisWall")
        {
            Left = !Left;
        }


    }
}
