using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] private FallForObstacle fallObj;
    [SerializeField] private LayerMask player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(LayerMaskCheck.ContainsLayer(player, collision.gameObject.layer))
        {
            fallObj.Fall();
        }    
    }
}
