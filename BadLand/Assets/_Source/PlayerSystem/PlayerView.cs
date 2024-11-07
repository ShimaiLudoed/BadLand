using System.Collections;
using System.Collections.Generic;
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
        public float tiltAngle = 15f;
        public float tiltSpeed = 5f; 

        private void Start()
        {
            Rb = GetComponent<Rigidbody2D>();
        }
        public void Move(float speed, Vector2 direction)
        {
            Vector3 dir = new Vector3(direction.x, direction.y, 0);
            transform.position += dir * speed * Time.deltaTime;
        }
        public void Jump(float force)
        {
            Rb.velocity = new Vector2(Rb.velocity.x, 0);
            Rb.AddForce(Vector3.up * force, ForceMode2D.Impulse); //типа умный
        }
        public void TiltCharacter(float moveInput)
        {
            float targetTilt = moveInput * tiltAngle;
            float currentTilt = Mathf.LerpAngle(transform.eulerAngles.z, targetTilt, Time.deltaTime * tiltSpeed);
            transform.rotation = Quaternion.Euler(0, 0, currentTilt);
            //не гноби плез :( (гпт) 
        }
    }
}