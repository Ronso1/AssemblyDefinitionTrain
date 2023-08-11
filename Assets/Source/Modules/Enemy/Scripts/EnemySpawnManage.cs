using UnityEngine;
namespace Enemy
{
    public class EnemySpawnManage : MonoBehaviour
    {
        [SerializeField] private EnemySpawn _spawnPoints;
        private bool _activated;
        private void Start()
        {
            if (_activated == false) return;
            _spawnPoints.StartSpawnEnemies();
        }
        public void Activate() => _activated = true;
        public void Deactivated() => _activated = false;
    }
}