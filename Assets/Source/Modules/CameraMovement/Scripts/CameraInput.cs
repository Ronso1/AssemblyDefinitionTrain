using UnityEngine;
namespace CameraPlayer
{
    public class CameraInput : MonoBehaviour
    {
        private const string MouseX = "Mouse X";
        private const string MouseY = "Mouse Y";
        [SerializeField] private float _sensitivity = 3f;
        [SerializeField] private CameraMovement _playerCamera;
        private bool _activate;
        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        private void Update()
        {
            if (_activate == false) return;
            _playerCamera.MoveCamera(MouseX, MouseY, _sensitivity);
        }
        public void Activate() => _activate = true;
        public void Deactivate() => _activate = false;
    }
}

