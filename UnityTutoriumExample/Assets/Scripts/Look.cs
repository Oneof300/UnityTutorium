using UnityEngine;
using UnityEngine.InputSystem;

namespace UnityTutorium.Character
{
    public class Look : MonoBehaviour
    {
        [SerializeField] float _rotationXMin = -90f;
        [SerializeField] float _rotationXMax = 90f;
        [SerializeField] Transform _target;

        Vector2 _input;
        Vector2 _rotation;

        // Start is called before the first frame update
        void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            _rotation.x = _target.rotation.x;
            _rotation.y = _target.rotation.y;
        }

        // Update is called once per frame
        void Update()
        {
            _rotation.x = Mathf.Clamp(_rotation.x - _input.y, _rotationXMin, _rotationXMax);
            _rotation.y += _input.x;
            _target.rotation = Quaternion.Euler(_rotation.x, _rotation.y, 0f);
        }

        public void OnInput(InputAction.CallbackContext context)
        {
            _input = context.ReadValue<Vector2>();
        }
    }
}