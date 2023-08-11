using UnityEngine;
namespace Enemy
{
    public class EnemyTrigger : MonoBehaviour
    {
        [SerializeField] private Collider _player;
        private void OnTriggerEnter(Collider other)
        {
            print("You lose!");
            Destroy(other.gameObject);
        }
    }
}
