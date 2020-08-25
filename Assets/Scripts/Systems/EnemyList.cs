using System;
using System.Linq;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using TowerDefense.Entities;
using UnityEngine;

namespace TowerDefense.System
{
    [CreateAssetMenu(order = 10, fileName = "EnemyList", menuName = "Tower Defense Game/Enemy List")]
    public class EnemyList : SerializedScriptableObject
    {
#if UNITY_EDITOR
        //Clear list on every startup of play mode
        private void OnEnable()
        {
            _enemies.Clear();
        }
#endif

        [SerializeField]
        private Dictionary<int, Enemy> _enemies = new Dictionary<int, Enemy>();

        public void AddEnemy(Enemy enemy)
        {
            try
            {
                _enemies.Add(enemy.GetInstanceID(), enemy);
            }
            catch (Exception e)
            {
                Debug.LogError(e);
                throw;
            }
        }

        public void RemoveEnemy(Enemy enemy)
        {
            try
            {
                _enemies.Remove(enemy.GetInstanceID());
            }
            catch (Exception e)
            {
                Debug.LogError(e);
                throw;
            }
        }

        public Enemy[] GetEnemies()
        {
            return _enemies
                .Select(keyValuePair => keyValuePair.Value)
                .ToArray();
        }
    }
}
