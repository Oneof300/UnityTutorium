using UnityEngine;
using UnityEngine.InputSystem;

namespace UnityTutorium.Character
{
    public class Move : MonoBehaviour
    {
        [SerializeField] float _speed = 5f;
        [SerializeField] float _gravity = -10f;
        [SerializeField] CharacterController _controller;
        [SerializeField] Transform _lookTarget;

        Vector2 _input;
        float _verticalVelocity;

        // Update is called once per frame
        void Update()
        {
            Vector3 motion = (_lookTarget.right * _input.x + _lookTarget.forward * _input.y) * _speed * Time.deltaTime;
            _verticalVelocity += _gravity * Time.deltaTime;
            motion.y = _verticalVelocity * Time.deltaTime;
            _controller.Move(motion);
        }

        void OnControllerColliderHit(ControllerColliderHit hit)
        {
            if (hit.moveDirection.y < -0.3f) _verticalVelocity = 0;
        }

        public void OnInput(InputAction.CallbackContext context)
        {
            _input = context.ReadValue<Vector2>();
        }
    }
}
