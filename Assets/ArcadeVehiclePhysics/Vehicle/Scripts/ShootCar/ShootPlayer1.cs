using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer1 : Shoot
{
  // Update is called once per frame
  void Update()
  {
    // 
    if (Input.GetKeyDown(KeyCode.H))
    {
      Fire();
    }

    if (Input.GetKeyDown(KeyCode.V))
    {
      TakeDamage(1);
    }
  }

  void TakeDamage(int damage)
  {
    currentHealth -= damage;

    healthBar.SetHealth(currentHealth);
  }
}
