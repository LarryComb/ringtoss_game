using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
  public Transform bumperStagingPoint, bumperMaxPoint;
  public string buttonName = "Fire1";

  [Tooltip("How long, in seconds, should it take to move to the max point.")]
  public float moveTime = 0.5f;

  private Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      var shouldBump = Input.GetButton(buttonName);
      var preferredPosition =
        shouldBump
          ? bumperMaxPoint.position
          : bumperStagingPoint.position;
      this.transform.position =
        Vector3.SmoothDamp(
          this.transform.position,
          preferredPosition,
          ref velocity,
          moveTime);
    }
}
