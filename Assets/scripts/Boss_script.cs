using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Boss_script : MonoBehaviour
{
    //Animations//
    public Animator BossFight;
    public Animator HitInvis;
    //Health//
    public int Health = 3;
    //Invicible Timer//
    public float Countdown = 1f;
    public bool CountDown;
    //Enemy Speed//
    public float speed = 0f;

    //Flips direction//
    public CircleCollider2D EdgeCheck;

    //Enemy hit box only killing the player//
    public BoxCollider2D Hit;
    //Enemy hit box only Boss hit if player is detected//
    public BoxCollider2D Ded;

    //Body to move//
    private Rigidbody2D RBody;

    //Direction at start and change direction if false//
    public bool Right = true;

    //Flip//
    public Transform Flip;

    //"Game over" scene//
    private string SCene = "1";

    //Sets body to move and the colliders that is used in diffrent situtions//
    private void Start()
    {
        RBody = GetComponent<Rigidbody2D>();
        EdgeCheck = GetComponent<CircleCollider2D>();
        Hit = GetComponent<BoxCollider2D>();
        Flip = GetComponent<Transform>();
        BossFight = GetComponent<Animator>();
        Ded = GetComponentInChildren<BoxCollider2D>();
        HitInvis = GetComponent<Animator>();
    }

    //Health amount//
    void Hhealth()
    {
        if (Health == 0 || Health <= 0)
        {
            BossTrigger.Trigger = false;
            Destroy(gameObject);
        }
        else if (Input.GetKey(KeyCode.O))
        {
            BossTrigger.Trigger = false;
            Destroy(gameObject);
        }
    }
    //Invicible at hit//
    void Ccoundown()
    {
        if (CountDown == true)
        {
            Countdown -= Time.deltaTime;
        }
        if (Countdown <= 0)
        {
            HitInvis.SetBool("HitInvis", false);
            CountDown = false;
        }
        if (CountDown == false)
        {
            Countdown = 1f;
        }
    }
    //Update handels all void's//
    void Movments()
    {
        if (Right == true)
        {
            RBody.velocity = ((Vector2)transform.right * speed);
            transform.localScale = new Vector3(2.7059f, 2.7059f, 2.7059f);
        }
        else
        {
            RBody.velocity = (-(Vector2)transform.right * speed);
            transform.localScale = new Vector3(-2.7059f, 2.7059f, 2.7059f);
        }
    }
    //Speed and direction//
    void Update()
    {
        Movments();
        Hhealth();
        Ccoundown();
    }

    //If no collison or InvisWall collision flip and if player is detected jumping on this obeject take 1 damage/
    private void OnCollisionExit2D(Collision2D collision)
    {
        Right = !Right;
    }
    private void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.tag == "Player")
        {
            Health -= 1;
            HitInvis.SetBool("HitInvis", true);
            CountDown = true;
            Coin.Passive = false;
        }
        if (collision.tag == "InvisWall")
        {
            Right = !Right;
        }
    }

    //If player hit then load "Game over" scene//
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            SceneManager.LoadScene(SCene);
        }

    }

    //Boss Entrance//
    private void FixedUpdate()
    {
        if (BossTrigger.Trigger == true)
        {
            BossFight.SetTrigger("Boss_Fight");
        }
    }

}
