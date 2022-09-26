using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAnimator : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] Vector3 _vector = Vector3.up;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_vector * _speed * Time.deltaTime, Space.Self);
    }
}
