using Movement;
using CameraPlayer;
using UnityEngine;
using Enemy;

public class GameRoot : MonoBehaviour
{
    [SerializeField] private MovementInput _playerMove;
    [SerializeField] private CameraInput _cameraInput;
    [SerializeField] private EnemySpawnManage _enemySpawnManage;
    private void Awake()
    {
        _cameraInput.Activate();
        _playerMove.Activate();
        _enemySpawnManage.Activate();
    }
}