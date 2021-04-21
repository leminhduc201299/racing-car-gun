using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CpInputPlayer2 : CpInput
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
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            _cpMain.input.accelInput = Input.GetAxis("Vertical") * speed;
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.UpArrow))
        {
            _cpMain.input.accelInput = 0;
        }

        //Steering
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _cpMain.input.steeringInput = Input.GetAxis("Horizontal") * speed;
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            _cpMain.input.steeringInput = 0;
        }
    }
}
