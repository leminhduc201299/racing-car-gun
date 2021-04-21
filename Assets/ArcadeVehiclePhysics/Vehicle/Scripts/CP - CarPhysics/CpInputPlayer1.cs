using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CpInputPlayer1 : MonoBehaviour
{
  [Space] public float accelerateAxis;
  public float brakingAxis;

  private CpMain _cpMain;

  private void Awake()
  {
    _cpMain = transform.parent.GetComponent<CpMain>();
  }

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    HandleInputs();
  }

  private void HandleInputs()
  {
    //   accelerateAxis = Input.GetAxis("Vertical");
    //Forward/Reverse
    if (Input.GetKeyDown(KeyCode.S))
    {
      _cpMain.input.accelInput = -0.5f;
    }
    else if (Input.GetKeyDown(KeyCode.W))
    {
      _cpMain.input.accelInput = 0.5f;
    }
    else if (Input.GetKeyUp(KeyCode.S))
    {
      _cpMain.input.accelInput = 0;
    }
    else if (Input.GetKeyUp(KeyCode.W))
    {
      _cpMain.input.accelInput = 0;
    }


    //Steering
    _cpMain.input.steeringInput = Input.GetAxis("Horizontal");
  }
}

[System.Serializable]
public class PlayerInputs
{
  public float accelInput;
  public float steeringInput;
}
