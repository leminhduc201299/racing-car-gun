using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CpInputPlayer1 : CpInput
{
  // Update is called once per frame
  void Update()
  {
    HandleInputs();
  }

  private void HandleInputs()
  {
    //Forward/Reverse
    if (
      Input.GetKeyDown(KeyCode.W) ||
      Input.GetKeyDown(KeyCode.S) ||
      Input.GetKeyUp(KeyCode.W) ||
      Input.GetKeyUp(KeyCode.S)
      )
    {
      _cpMain.input.accelInput = Input.GetAxis("Vertical");
    }

    //Steering
    if (
      Input.GetKeyDown(KeyCode.A) ||
      Input.GetKeyDown(KeyCode.D) ||
      Input.GetKeyUp(KeyCode.A) ||
      Input.GetKeyUp(KeyCode.D)
    )
    {
      _cpMain.input.steeringInput = Input.GetAxis("Horizontal");
    }
  }
}