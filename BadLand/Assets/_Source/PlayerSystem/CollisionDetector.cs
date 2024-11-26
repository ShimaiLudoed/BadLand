using PlayerSystem;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CollisionDetector : MonoBehaviour
{
    public event Action OnPlayerDead;
    public event Action OnPlayerFinish;
    private PlayerController _playerController;
    [SerializeField] private LayerMask powerUp;
    private ChangeMass _changeMass;
    [SerializeField] private LayerMask saw;
    [SerializeField] private LayerMask fallingObstacle;
    [SerializeField] private LayerMask finish;
    [SerializeField] private PlayerView _playerView;

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
        if(LayerMaskCheck.ContainsLayer(fallingObstacle,collision.gameObject.layer)&& _playerView.IsGround)
        {
            OnPlayerDead?.Invoke();
        }

        if (LayerMaskCheck.ContainsLayer(finish, collision.gameObject.layer))
        {
            OnPlayerFinish?.Invoke();
        }
    }
}
