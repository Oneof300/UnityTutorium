using UnityEngine;
using UnityEngine.Events;

public class TriggerListener : MonoBehaviour
{
    [SerializeField] UnityEvent EnterResponse;
    [SerializeField] UnityEvent ExitResponse;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter raised");
        EnterResponse.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit raised");
        ExitResponse.Invoke();
    }
}
