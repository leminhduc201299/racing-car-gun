using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CursorHideScript : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    Cursor.visible = false;
    // border = new VectorLine("border", new Vector2[5], null, borderWidth, LineType.Continuous, Joins.Weld);
  }

  // Update is called once per frame
  void Update()
  {
  }
}
