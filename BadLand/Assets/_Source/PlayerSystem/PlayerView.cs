using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerView : MonoBehaviour
    {
        //[SerializeField] private Sprite playerSprite;
        public Transform Transform { get; private set; }
        private Rigidbody2D Rb;
        public float Speed;
        public float Force;
        public float tiltAngle;
        public float tiltSpeed; 
        public bool IsGround { get; private set; }
        [SerializeField] private LayerMask groundLayer;
        

        private void Start()
        {
            Rb = GetComponent<Rigidbody2D>();
        }
        private void Update()
        {
            Debug.Log(IsGround);
        }
        public void Move(float speed, Vector2 direction)
        {
            Rb.velocity = new Vector2(direction.x * speed, Rb.velocity.y);
        }
        public void Jump(float force)
        {
            Rb.velocity = new Vector2(Rb.velocity.x, 0);
            Rb.AddForce(Vector3.up * force, ForceMode2D.Impulse); //���� �����
        }
        public void TiltCharacter(float moveInput)
        {
            float currentTilt = Rb.rotation;
            if (!IsGround)
            {
                float targetTilt = moveInput * tiltAngle;
                Rb.rotation=NewAngle(currentTilt, targetTilt);
            }
            else
            {
                if (moveInput != 0)
                {
                    currentTilt += moveInput * tiltSpeed * tiltSpeed;
                    if (currentTilt >= 360f) 
                    {
                        currentTilt -= 360f; 
                    }

                    Rb.rotation = currentTilt; 
                }
                else
                {
                    Rb.rotation = NewAngle(currentTilt, 0);
                }
            }
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(LayerMaskCheck.ContainsLayer(groundLayer,collision.gameObject.layer))
            {
                IsGround = true;
            }
        }
        private void OnCollisionExit2D(Collision2D collision)
        {
            if (LayerMaskCheck.ContainsLayer(groundLayer, collision.gameObject.layer))
            {
                IsGround = false;
            }
        }

        private float NewAngle(float CurrentTilt,float TargetTilt)
        {
            return Mathf.Lerp(CurrentTilt, TargetTilt, tiltSpeed);
        }
        public void ChangeMass(float multy)
        {
            transform.localScale*=multy;
            Rb.mass *= multy;
        }
        public void Death()
        {
            Destroy(gameObject);
        }
    }
}