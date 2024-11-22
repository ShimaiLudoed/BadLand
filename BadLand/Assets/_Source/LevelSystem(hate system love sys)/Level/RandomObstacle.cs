using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

namespace LevelSystem
{
    public class RandomObstacle : MonoBehaviour
    {
        [SerializeField] private float disablePercentage;
        [SerializeField] private LayerMask obstacleLayer;

        private void Start()
        {
            DisableObstacle();
        }

        public void DisableObstacle()
        {
            List<GameObject> obstacles = new List<GameObject>();
            
            foreach (Transform child in transform)
            {
                if (LayerMaskCheck.ContainsLayer(obstacleLayer, child.gameObject.layer))
                {
                    obstacles.Add(child.gameObject);
                    Debug.Log(obstacles.Count);
                }
            }

            int numberToDisable = Mathf.FloorToInt(obstacles.Count * disablePercentage);

            Shuffle(obstacles);

            for (int i = 0; i < numberToDisable; i++)
            {
                if (i < obstacles.Count)
                {
                    obstacles[i].SetActive(false);
                    Debug.Log("Выключил");
                }
            }
        }
        public void Shuffle(List<GameObject> list)
        {
            System.Random rng = new System.Random();
            int n = list.Count;
            while (n > 1)
            {
                int k = rng.Next(n);
                n--;
                GameObject value = list[k];
                list[k] = list[n];
                list[n] = value;
                Debug.Log("перемешал");
            }
            
            /*Random random = new Random();
            var randomOrder = numbers.OrderBy(x => random.Next());*/
        }
    }
}