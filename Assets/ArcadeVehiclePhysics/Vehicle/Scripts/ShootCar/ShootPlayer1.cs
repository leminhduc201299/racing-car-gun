using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer1 : Shoot
{
  // Update is called once per frame
  void Update()
  {
    // 
    if (Input.GetMouseButton(0))
    {
      Fire("Player 01");
    }

  }
}
