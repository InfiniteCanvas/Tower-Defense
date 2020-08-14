using TowerDefense.Entities;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
namespace TowerDefense.Events
{
    [CreateAssetMenu(order = 0, fileName = "EnemyEvent", menuName = "Tower Defense Game/Enemy Event")]
    public class EnemyEvent : SerializedScriptableObject
    {
        private List<EnemyEventListener> _listeners = new List<EnemyEventListener>();

        public void Raise(Enemy enemy)
        {
            for (int i = _listeners.Count - 1; i >= 0; i--)
            {
                _listeners[i].OnEventRaised(enemy);
            }
        }

        public void AddListener(EnemyEventListener listener)
        {
            _listeners.Add(listener);
        }

        public void RemoveListener(EnemyEventListener listener)
        {
            _listeners.Remove(listener);
        }
    }
}
