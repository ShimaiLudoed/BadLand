using LevelSystem_hate_system_love_sys_;
using PlayerSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class InputListener : MonoBehaviour
    {
        private PlayerController _playerController;
        private LevelController _levelController;

        public void Construct(PlayerController player,LevelController level)
        {
            _playerController = player;
            _levelController = level;
        }
        private void Update()
        {
            if (_playerController != null)
            {
                float horizontal;
                horizontal = Input.GetAxis("Horizontal");
                Vector2 vec = new Vector2(horizontal, 0).normalized;
                _playerController.Move(vec);
                _playerController.TiltCharacter(horizontal);
            }

            if (_levelController != null)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    _levelController.Pause();
                }
            }
        }
        private void LateUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {

                _playerController.Jump();
            }
        }
    }
}