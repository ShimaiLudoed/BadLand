using LevelSystem;
using UnityEngine;

namespace LevelSystem
{
    public class Trap : MonoBehaviour
    {
        [SerializeField] private FallForObstacle fallObj;
        [SerializeField] private LayerMask player;
        private void OnTriggerEnter2D(Collider2D other)
        {
            if(LayerMaskCheck.ContainsLayer(player, other.gameObject.layer))
            {
                fallObj.Fall();
                Debug.Log("Пуп");
            }    
        }
    }
}
