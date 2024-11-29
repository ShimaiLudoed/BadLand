using DG.Tweening;
using System;
using UnityEngine;

namespace LevelSystem
{
    public class FallForObstacle : MonoBehaviour
    {
        [SerializeField] private Transform endPoint;
        [SerializeField] private float duration;
        [SerializeField] private LayerMask ground;

        public void Fall()
        {
            transform.DOMove(endPoint.position, duration);
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (LayerMaskCheck.ContainsLayer(ground, other.gameObject.layer))
            {
                Destroy(gameObject);
            }
        }
    }
}
