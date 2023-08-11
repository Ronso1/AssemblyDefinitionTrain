using UnityEngine;
internal class CharacterMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    internal void Move(Vector3 direction)
    {
        transform.Translate(direction * _speed * Time.deltaTime);
    }
}
