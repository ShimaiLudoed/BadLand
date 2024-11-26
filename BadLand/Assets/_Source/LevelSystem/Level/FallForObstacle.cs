using DG.Tweening;
using UnityEngine;

namespace LevelSystem
{
    public class FallForObstacle : MonoBehaviour
    {
        [SerializeField] private Transform endPoint;
        [SerializeField] private float duration;

        public void Fall()
        {
            transform.DOMove(endPoint.position, 3);
        }
    }
}
