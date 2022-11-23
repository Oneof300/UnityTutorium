using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    [SerializeField] Event _event;
    [SerializeField] UnityEvent Response;

    private void OnEnable() {
        _event.AddListener(Response);
    }

    private void OnDisable() {
        _event.RemoveListener(Response);
    }
}
