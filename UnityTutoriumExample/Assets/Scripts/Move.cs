using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    [SerializeField] CharacterController _controller;
    [SerializeField] float _gravity = -9.81f;

    Vector2 _input;
    float _verticalVelocity;

    
    // Start is called before the first frame update
    void Start()
    {
        _verticalVelocity = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, -transform.up, out RaycastHit hit, 0.1f))
            _verticalVelocity = 0;
        else
            _verticalVelocity += _gravity * Time.deltaTime;

        // transform: Transformation (Position/Rotation/Skalierung) des Objekts, an dem dieses Skript angefügt ist
        _controller.Move((transform.right * _input.x + transform.forward * _input.y + Vector3.up * _verticalVelocity) * 10f * Time.deltaTime);
    }

    public void OnInput(InputAction.CallbackContext context)
    {
        // Input value: ( x, y )
        // x := A: -1 oder D: 1 oder weder A noch D: 0
        // y := S: -1 oder W: 1 oder weder S noch W: 0
        _input = context.ReadValue<Vector2>();
    }
}
