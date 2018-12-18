using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Game : MonoBehaviour
{
    public bool Quit = false;
    //Quits The Game//
    private void Start()
    {
        Quit = false;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Joystick1Button7))
        {
            Quit = true;
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Quit = true;
        }
        if (Quit==true)
        {
            Application.Quit();   
        }
        
        

        
    }
}
