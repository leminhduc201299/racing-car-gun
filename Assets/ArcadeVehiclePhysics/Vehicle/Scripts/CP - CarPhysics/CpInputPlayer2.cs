using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CpInputPlayer2 : MonoBehaviour
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
    if (Input.GetKeyDown(KeyCode.DownArrow))
    {
      _cpMain.input.accelInput = -0.5f;
    }
    else if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      _cpMain.input.accelInput = 0.5f;
    }
    else if (Input.GetKeyUp(KeyCode.DownArrow))
    {
      _cpMain.input.accelInput = 0;
    }
    else if (Input.GetKeyUp(KeyCode.UpArrow))
    {
      _cpMain.input.accelInput = 0;
    }


    //Steering
    _cpMain.input.steeringInput = Input.GetAxis("Horizontal");
  }
}