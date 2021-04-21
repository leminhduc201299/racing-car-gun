using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CpInputPlayer2 : CpInput
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
      Input.GetKeyDown(KeyCode.DownArrow) ||
      Input.GetKeyDown(KeyCode.UpArrow) ||
      Input.GetKeyUp(KeyCode.DownArrow) ||
      Input.GetKeyUp(KeyCode.UpArrow)
      )
    {
      _cpMain.input.accelInput = Input.GetAxis("Vertical");
    }

    //Steering
    if (
      Input.GetKeyDown(KeyCode.RightArrow) ||
      Input.GetKeyDown(KeyCode.LeftArrow) ||
      Input.GetKeyUp(KeyCode.RightArrow) ||
      Input.GetKeyUp(KeyCode.LeftArrow)
    )
    {
      _cpMain.input.steeringInput = Input.GetAxis("Horizontal");
    }
  }
}
