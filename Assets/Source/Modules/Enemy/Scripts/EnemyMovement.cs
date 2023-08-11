using UnityEngine;
namespace Enemy
{
    internal class EnemyMovement : MonoBehaviour
    {
        private float _time;
        private void Update()
        {
            transform.Translate(-Vector3.forward.normalized * Time.deltaTime * Random.Range(8.2f, 15.5f));
            _time += Time.deltaTime;
            if (_time > 5f) Destroy(transform.gameObject);
        }
    }
}