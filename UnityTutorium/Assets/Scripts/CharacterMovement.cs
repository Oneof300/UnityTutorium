using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float translateSpeed = 10f;
    public float rotateSpeed = 100f;
    public float headRotationMin = -60f;
    public float headRotationMax = 60f;
    public string axisTranslationX = "Horizontal";
    public string axisTranslationZ = "Vertical";
    public string axisRotationX = "Mouse Y";
    public string axisRotationY = "Mouse X";
    public CharacterController controller;
    public Transform headTransform;

    private float headRotation;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        headRotation = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float
            translationX = Input.GetAxis(axisTranslationX),
            translationZ = Input.GetAxis(axisTranslationZ),
            rotationX = Input.GetAxis(axisRotationX),
            rotationY = Input.GetAxis(axisRotationY)
        ;

        controller.Move((transform.right * translationX + transform.forward * translationZ) * translateSpeed * Time.deltaTime);

        headRotation = Mathf.Clamp(headRotation - rotationX * rotateSpeed * Time.deltaTime, headRotationMin, headRotationMax);
        headTransform.localRotation = Quaternion.Euler(headRotation, 0f, 0f);

        transform.Rotate(Vector3.up * rotationY * rotateSpeed * Time.deltaTime);
    }
}
