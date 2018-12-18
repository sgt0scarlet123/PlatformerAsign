using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movments : MonoBehaviour
{
    //Change how many times one can jump//
    public int Jump = 1;
    //How fast one runs//
    public float moveSpeed = 5;
    //How high one jumps//
    public float jumpSpeed = 11;

    //GroubdChceker script//
    public GroundChecker groundCheck;

    //The body one wish to move when one inputs a directional button//
    private Rigidbody2D rbody;

    //Sets the body one can move//
    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    //Movement left<->right and the jump button//
    void Update()
    {
        rbody.velocity = new Vector2
           (Input.GetAxisRaw("Horizontal") * moveSpeed,
            rbody.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            if (groundCheck.isGrounded == true || Jump > 0)
            {
                rbody.velocity = new Vector2
                (rbody.velocity.x, jumpSpeed);
                Jump -= 1;
            }

        }
        if (groundCheck.isGrounded == true)
        {
            Jump = 1;
        }
        if (BossTrigger.Trigger == true)
        {
            jumpSpeed = 13;
        }
        else if (BossTrigger.Trigger == false)
        {
            jumpSpeed = 11;
        }
    }




    //Jumping on a boss Forces automatic jump//
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Boss")
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
        }
    }

}




