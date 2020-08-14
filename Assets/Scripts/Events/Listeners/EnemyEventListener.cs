using System;
using TowerDefense.Entities;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TowerDefense.Events
{
    public class EnemyEventListener : MonoBehaviour
    {
        public EnemyUnityEvent Response;
        public EnemyEvent Event;

        private void OnEnable()
        {
            Event.AddListener(this);
        }

        private void OnDisable()
        {
            Event.RemoveListener(this);
        }

        public void OnEventRaised(Enemy enemy)
        {
            Response.Invoke(enemy);
        }
    }

    [Serializable]
    public class EnemyUnityEvent : UnityEvent<Enemy>
    {
    }
}
