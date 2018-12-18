using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossZone : MonoBehaviour {
    //BossFightCamera//
    public Camera BossFightCamera;
    //Get Camera Component//
    private void Start()
    {
        BossFightCamera = GetComponent<Camera>();
    }
    //If Trigger is true than switch to Boss Fight Camera else Switch to main camera//
    private void Update()
    {
        if (BossTrigger.Trigger == true)
        {
            BossFightCamera.depth = 1f;
        }
        else if (BossTrigger.Trigger == false)
        {
            BossFightCamera.depth = -1f;
        }
    }
}
