using System;
using TowerDefense.Entities;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace TowerDefense.Events
{
    public class EnemyEventListener : MonoBehaviour
    {
        [TextArea]
        public string EventInfo;

        public EnemyEvent Event;
        [Space(10)]
        public EnemyUnityEvent Response;

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
