using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vectrosity;

public class CpMain : MonoBehaviour
{
  public PlayerInputs input;
  public VehicleSpeed speedData;
  public CpWheelData wheelData;

  [HideInInspector] public Rigidbody rb;
  public Vector3 averageColliderSurfaceNormal;

  private bool _prevGroundedState;
  public static event Action<CpMain> OnLeavingGround = cpMain => { };
  public static event Action<CpMain> OnLanding = cpMain => { };

  private VectorLine border;
  int borderWidth = 4;
  private int screenWidth;
  private void Awake()
  {
    rb = GetComponentInChildren<Rigidbody>();
  }

  void Start()
  {
    // UpdateBorder();
  }
  private void Update()
  {
    if (_prevGroundedState == false && wheelData.grounded)
    {
      OnLanding(this);
    }
    else if (_prevGroundedState == true && !wheelData.grounded)
    {
      OnLeavingGround(this);
    }

    _prevGroundedState = wheelData.grounded;
    // UpdateBorder();
  }


  // private void UpdateBorder()
  // {
  //   border.MakeRect(new Vector2(borderWidth / 2, borderWidth / 2),
  //                   new Vector2(Screen.width - borderWidth / 2, Screen.height - borderWidth / 2));
  //   border.Draw();
  //   screenWidth = Screen.width;
  // }
}
