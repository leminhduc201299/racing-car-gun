﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer2 : Shoot
{
  // Update is called once per frame
  void Update()
  {
    // Khi nhan chuot trai de ban
    if (Input.GetKeyDown(KeyCode.H))
    {
      Fire("Player 02");
    }
  }
}
