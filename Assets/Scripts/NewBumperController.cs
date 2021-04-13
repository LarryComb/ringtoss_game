using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBumperController : MonoBehaviour
{
  public float force, radius, upwardsModifier;
public string buttonName = "Fire1";

    // Start is called before the first frame update
    void Start()
    {

    }

      // Update is called once per frame
      void Update()
      {
        var shouldBump = Input.GetButton(buttonName);
        if(shouldBump)
        {
          var rigidBodies =      FindObjectsOfType<Rigidbody>();
          foreach(var rigidBody in rigidBodies)
          {
          rigidBody.AddExplosionForce(force, transform.position, radius, upwardsModifier);
          }
        }
      }
}
