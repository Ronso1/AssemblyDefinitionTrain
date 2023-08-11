using UnityEngine;
public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float _verticalLover = 80f;
    [SerializeField] private float _verticalUpper = -80f;
    [SerializeField] private Transform _player;
    private float _currentVerticalAngle;
    public void MoveCamera(string mouseX, string mouseY, float sensitivity)
    {
        var vertical = -Input.GetAxis(mouseY) * sensitivity;
        var horizontal = Input.GetAxis(mouseX) * sensitivity;
        _currentVerticalAngle = Mathf.Clamp(_currentVerticalAngle + vertical, _verticalUpper, _verticalLover);
        transform.localRotation = Quaternion.Euler(_currentVerticalAngle, 0, 0);
        _player.Rotate(0, horizontal, 0);
    }
}