using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityTutorium.Character
{
    public class Push : MonoBehaviour
    {
        [SerializeField, Range(0.5f, 5f)] float _strength = 1f;

        void OnControllerColliderHit(ControllerColliderHit hit)
        {
            Rigidbody body = hit.collider.attachedRigidbody;
            if (!body || body.isKinematic || hit.moveDirection.y < -0.3f) return;

            body.AddForce(new Vector3(hit.moveDirection.x, 0.0f, hit.moveDirection.z) * _strength, ForceMode.Impulse);
        }
    }
}
