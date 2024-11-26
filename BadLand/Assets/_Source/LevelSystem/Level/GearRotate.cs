using UnityEngine;

namespace LevelSystem
{
    public class GearRotate : MonoBehaviour
    {
        [SerializeField] private float rotationSpeed; 

        void Update()
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
    }
}
