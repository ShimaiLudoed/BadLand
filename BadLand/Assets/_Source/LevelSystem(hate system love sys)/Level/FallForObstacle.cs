using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallForObstacle : MonoBehaviour
{
    [SerializeField] private Transform endPoint;
    [SerializeField] private float duration;

    public void Fall()
    {
        transform.DOMove(endPoint.position, 3);
    }
}
