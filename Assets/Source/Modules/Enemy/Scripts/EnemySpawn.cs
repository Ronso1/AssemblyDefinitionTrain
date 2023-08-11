using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Enemy
{
    public class EnemySpawn : MonoBehaviour
    {
        [SerializeField] private List<Transform> _spawners;
        [SerializeField] private GameObject _enemy;
        public void StartSpawnEnemies() => StartCoroutine(SpawnEnemy());
        private IEnumerator SpawnEnemy()
        {
            var waitTime = new WaitForSeconds(2f);
            while (true)
            {
                yield return waitTime;
                int rnd = Random.Range(0, 3);
                Instantiate(_enemy, _spawners[rnd].position, _spawners[rnd].rotation);
            }
        }
    }
}