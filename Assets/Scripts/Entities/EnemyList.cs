using Sirenix.OdinInspector;

namespace TowerDefense.Entities
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    
    [CreateAssetMenu]
    public class EnemyList : SerializedScriptableObject
    {
        private List<Enemy> _enemies;

        private EnemyList()
        {
            _enemies = new List<Enemy>();
        }

        public void AddEnemy(Enemy enemy)
        {
            _enemies.Add(enemy);
        }

        public void RemoveEnemy(Enemy enemy)
        {
            _enemies.Remove(enemy);
        }
    }
}
