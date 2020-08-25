using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using TowerDefense.Entities;
using TowerDefense.Events;
using UnityEngine.Serialization;

namespace TowerDefense.System
{
    public class Spawner : SerializedMonoBehaviour
    {
        [Header("Events")]
        [SerializeField] private EnemyEvent _spawnEvent;
        [SerializeField] private EnemyList _enemyList;

        [Header("Enemy Info")] 
        [SerializeField] private GameObject EnemyPrefab;
        [SerializeField] private float _spawnFrequency;

        private void Start()
        {
            TestSpawnInInterval();
        }

        private void TestSpawnInInterval()
        {
            StartCoroutine(SpawnInIntervals());
        }

        private IEnumerator SpawnInIntervals()
        {
            var counter = 0f;
            for (;;)
            {
                counter += Time.fixedDeltaTime;
                if(counter>_spawnFrequency)
                {
                    SpawnEnemy(EnemyPrefab);
                    counter = 0;
                }

                yield return new WaitForFixedUpdate();
            }
        }
        
        public void SpawnEnemy(GameObject enemyPrefab)
        {
            var go = Instantiate(enemyPrefab);
            var enemy = go.GetComponent<Enemy>();
            
            go.transform.position = Vector3.zero;
            
            _spawnEvent.Raise(enemy);
        }
    }
}
