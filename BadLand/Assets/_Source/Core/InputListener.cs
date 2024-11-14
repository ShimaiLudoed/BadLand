using PlayerSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class InputListener : MonoBehaviour
    {
        private PlayerController _playerController;

        public void Construct(PlayerController player)
        {
            _playerController = player;
        }
        private void Update()
        {
            if (_playerController != null)
            {
                float horizontal;
                horizontal = Input.GetAxis("Horizontal");
                Vector2 vec = new Vector2(horizontal, 0).normalized;
                _playerController.Move(vec);
               // _playerController.TiltCharacter(horizontal);
                if (Input.GetKeyDown(KeyCode.Space)) 
                {

                    _playerController.Jump();
                }
            }
        }
    }
}