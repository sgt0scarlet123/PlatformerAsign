using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    //Route Bools//
    public bool Pas;
    public bool Gen;
    public bool Sec;
    //Choice Possition//
    private Vector2 one = new Vector2(-5.02f, -0.81f);
    private Vector2 two = new Vector2(5.02f, -0.81f);
    private Vector2 three = new Vector2(0.473f, -4.11f);
    //Void Update handels Choices and starting the game proper//
    private void Update()
    {
        Pasifist();
        Genocide();
        Secret();
        if (Input.GetKey(KeyCode.C)&& Pas == true)
        {
            SceneManager.LoadScene("SampleScene");
        }
        else if (Input.GetKey(KeyCode.Joystick1Button6) && Pas == true)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (Input.GetKey(KeyCode.C) && Gen == true)
        {
            SceneManager.LoadScene("SampleScene");
        }
        else if (Input.GetKey(KeyCode.Joystick1Button6) && Gen == true)
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (Input.GetKey(KeyCode.C)&& Sec == true)
        {
            SceneManager.LoadScene("1");
        }
        else if (Input.GetKey(KeyCode.Joystick1Button6) &&Sec == true)
        {
            SceneManager.LoadScene("1");
        } 
    }
    //Pasifist Choice//
    void Pasifist()
    {
        if (Input.GetAxis("Horizontal")==-1)
        {    
            transform.position = one;
            Pas = true;
            Gen = false;
            Sec = false;
            Coin.Passive = true;
        }

    }
    //Genocide Choice//
    void Genocide()
    {
        if (Input.GetAxis("Horizontal")==1)
        {
            transform.position = two;
            Gen = true;
            Pas = false;
            Sec = false;
            Coin.Passive = false;

        }

    }
    //Secret Choice//
    void Secret()
    {
        if (Input.GetAxis("Vertical")==-1)
        {
            transform.position = three;
            Sec = true;
            Pas = false;
            Gen = false;
            Coin.Passive = false;

        }

    }
}
