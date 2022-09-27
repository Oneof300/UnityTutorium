using UnityEngine;

namespace UnityTutorium
{
    public class RotationAnimator2 : MonoBehaviour
    {
        [SerializeField] FloatValue _speed;
        [SerializeField] Vector3 _direction = Vector3.up;

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(_direction * _speed.Value * Time.deltaTime, Space.Self);
        }
    }
}
