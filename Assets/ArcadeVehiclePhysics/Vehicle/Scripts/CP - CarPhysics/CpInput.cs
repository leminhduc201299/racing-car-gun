using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CpInput : MonoBehaviour
{
  [Space] public float accelerateAxis;
  public float brakingAxis;

  protected CpMain _cpMain;

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
  }
}

[System.Serializable]
public class PlayerInputs
{
  public float accelInput;
  public float steeringInput;
}
