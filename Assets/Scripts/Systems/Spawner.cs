using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TowerDefense.Entities;
using TowerDefense.Events;

namespace TowerDefense.System
{
    public class Spawner : MonoBehaviour
    {
        public EnemyEvent SpawnEvent;
        public EnemyList EnemyList;

        private void Start()
        {
            SpawnEnemy(gameObject.AddComponent<Enemy>());
        }
        
        public void SpawnEnemy(Enemy enemy)
        {
            SpawnEvent.Raise(enemy);
        }

        public void TestResponse(Enemy enemy)
        {
            Debug.Log($"Enemy with instance id {enemy.GetInstanceID()} spawned and added to list");
            EnemyList.AddEnemy(enemy);
            Debug.Log($"Enemylist has: {EnemyList.GetEnemies().Length} enemies");
        }
    }
}
