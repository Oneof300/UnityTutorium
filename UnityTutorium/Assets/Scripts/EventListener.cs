using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UnityTutorium
{
    public class EventListener : MonoBehaviour
    {
        [SerializeField] Event _event;
        [SerializeField] UnityEvent _response;

        void OnEnable() =>
            _event.AddListener(_response.Invoke);

        void OnDisable() =>
            _event.RemoveListener(_response.Invoke);
    }
}
