using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerSystem
{
    public class PlayerModel
    {
        public float Speed { get; private set; }
        public float Force { get; private set; }

        public PlayerModel(float speed, float force)
        {
            Speed = speed;
            Force = force;
        }

    }
}