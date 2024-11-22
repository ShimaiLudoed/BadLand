using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacle : MonoBehaviour
{
  [SerializeField] private LayerMask player;
  [SerializeField] private float mass;
  private void OnCollisionEnter2D(Collision2D other)
  {
    Rigidbody2D otherRig = other.rigidbody;
    if (otherRig != null)
    {
      float rigMass = otherRig.mass;
      if (LayerMaskCheck.ContainsLayer(player, other.gameObject.layer));
      {
        if(rigMass >= mass)
        {
          Destroy(gameObject); 
        }
      }
    }
  }
}
