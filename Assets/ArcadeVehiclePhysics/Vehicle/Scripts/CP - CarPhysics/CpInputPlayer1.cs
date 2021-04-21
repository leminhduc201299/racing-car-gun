using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CpInputPlayer1 : CpInput
{
    public float speed = 10;
    // Update is called once per frame
    void Update()
    {
        HandleInputs();
    }

    private void HandleInputs()
    {
        //Forward/Reverse
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
        {
            _cpMain.input.accelInput = Input.GetAxis("Vertical") * speed;
        }
        else if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            _cpMain.input.accelInput = 0;
        }

        //Steering
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            _cpMain.input.steeringInput = Input.GetAxis("Horizontal") * speed;
        }
        else if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            _cpMain.input.steeringInput = 0;
        }
    }
}