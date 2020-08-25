using System.Collections;
using System.Collections.Generic;
using TowerDefense.System;
using UnityEngine;
namespace TowerDefense.Entities
{
    public class Tower : MonoBehaviour
    {
        public static Enemy[] CachedEnemyList;
        public EnemyList EnemyList;

        public void RefreshEnemyList()
        {
            CachedEnemyList = EnemyList.GetEnemies();
            Debug.Log("Enemies: "+CachedEnemyList.Length);
        }
    }
}