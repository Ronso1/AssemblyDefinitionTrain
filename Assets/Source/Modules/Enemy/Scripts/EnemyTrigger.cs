using UnityEngine;
using Zenject;
namespace Enemy
{
    public class EnemyTrigger : MonoBehaviour
    {
        [SerializeField] private Collider _player;
        [Inject]
        public void Construct(Collider player)
        {
            _player = player;
        }

        private void OnTriggerEnter(Collider other)
        {
            print("You lose!");
            Destroy(other.gameObject);
        }
    }
}
