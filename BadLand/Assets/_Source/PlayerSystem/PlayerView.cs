using System.Collections;
using System.Collections.Generic;
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
            Vector3 dir = new Vector3(direction.x, direction.y, 0);
            Rb.velocity = dir * speed * Time.deltaTime;
        }
        public void Jump(float force)
        {
            Rb.velocity = new Vector2(Rb.velocity.x, 0);
            Rb.AddForce(Vector3.up * force, ForceMode2D.Impulse); //типа умный
        }
        public void TiltCharacter(float moveInput)
        {
/*            if (!IsGround)
            {
                float targetTilt = moveInput * tiltAngle;
                float currentTilt = Mathf.LerpAngle(transform.eulerAngles.z, targetTilt, Time.deltaTime * tiltSpeed);
                transform.rotation = Quaternion.Euler(0, 0, currentTilt);
                //не гноби плез :( (гпт) 
            }
            else
            {
                Rb.angularVelocity
            }*/
                    
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
    }
}