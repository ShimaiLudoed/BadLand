using PlayerSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    public event Action OnPlayerDead;
    private PlayerController _playerController;
    [SerializeField] private LayerMask powerUp;
    private ChangeMass _changeMass;
    [SerializeField] private LayerMask saw;

    public void Construct(PlayerController playerController)
    {
        _playerController= playerController;   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(LayerMaskCheck.ContainsLayer(powerUp,collision.gameObject.layer))
        {
            _changeMass=collision.gameObject.GetComponent<ChangeMass>();
            _playerController.ChangeMass(_changeMass.Multy);
            Destroy(collision.gameObject);
        }
        if(LayerMaskCheck.ContainsLayer(saw,collision.gameObject.layer))
        {
            OnPlayerDead?.Invoke();
        }
    }
}
