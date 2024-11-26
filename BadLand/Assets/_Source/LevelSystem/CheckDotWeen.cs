using DG.Tweening;
using System;
using UnityEngine;

namespace LevelSystem
{
    public class CheckDotWeen : MonoBehaviour
    {
        [SerializeField] private Transform endPoint;
        [SerializeField] private float duration;
        [SerializeField] private AnimationCurve ease;

        private void Awake()
        {
            //Moveblin(AnimationCallback);
            UniversalTween();
        }

        private void Moveblin(Action callback = null)
        {
            Tween moveTween = transform.DOMove(endPoint.position, duration)
                .SetEase(ease)
                .OnComplete(() =>
                {
                    callback?.Invoke();
                })
                .OnUpdate(() =>
                {
                    Debug.Log(transform.position);
                });
        }

        private void UniversalTween()
        {
            float timer = 10;
            DOTween.To(() => timer, x => timer = x, 0, timer)
                .OnUpdate(() =>
                {
                    Debug.Log(timer);
                });
        }

        private void AnimationCallback()
        {
            Debug.Log("Complete animation!");
        }
    }
}
